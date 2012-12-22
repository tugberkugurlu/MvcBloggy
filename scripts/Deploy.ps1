param(
    $msDeployServerName = $env:MvcBloggy_MSDEPLOY_SERVER_NAME,
    $msDeployUserName = $env:MvcBloggy_MSDEPLOY_USERNAME,
    $msDeployPassword = $env:MvcBloggy_MSDEPLOY_PASSWORD,
    $msDeployWebsiteName = $env:MvcBloggy_MSDEPLOY_WEBSITE_NAME,
    $mvcBloggyDbSqlConnectionString = $env:MvcBloggy_DB_SQL_CONNECTION_STRING,
    $mvcBloggyEmail = $env:MvcBloggy_EMAIL,
    $mvcBloggyEmailHost = $env:MvcBloggy_EMAIL_HOST,
    $mvcBloggyEmailUsername = $env:MvcBloggy_EMAIL_USERNAME,
    $mvcBloggyEmailPassword = $env:MvcBloggy_EMAIL_PASSWORD,
    $mvcBloggyEmailPort = $env:MvcBloggy__EMAIL_PORT,
    $mvcBloggyReCaptchaPublicKey = $env:MvcBloggy_RECAPTCHA_PUBLIC_KEY,
    $mvcBloggyReCaptchaPrivateKey = $env:MvcBloggy_RECAPTCHA_PRIVATE_KEY
)

# Import Common Stuff
$ScriptRoot = (Split-Path -parent $MyInvocation.MyCommand.Definition)
. $ScriptRoot\_Common.ps1

#Load assemblies
[System.Reflection.Assembly]::LoadWithPartialName("System.web") | out-null

require-param -value $msDeployServerName -paramName "msDeployServerName"
require-param -value $msDeployUserName -paramName "msDeployUserName"
require-param -value $msDeployPassword -paramName "msDeployPassword"
require-param -value $msDeployWebsiteName -paramName "msDeployWebsiteName"
require-param -value $mvcBloggyDbSqlConnectionString -paramName "mvcBloggyDbSqlConnectionString"
require-param -value $mvcBloggyEmail -paramName "mvcBloggyEmail"
require-param -value $mvcBloggyEmailHost -paramName "mvcBloggyEmailHost"
require-param -value $mvcBloggyEmailUsername -paramName "mvcBloggyEmailUsername"
require-param -value $mvcBloggyEmailPassword -paramName "mvcBloggyEmailPassword"
require-param -value $mvcBloggyEmailPort -paramName "mvcBloggyEmailPort"
require-param -value $mvcBloggyReCaptchaPublicKey -paramName "mvcBloggyReCaptchaPublicKey"
require-param -value $mvcBloggyReCaptchaPrivateKey -paramName "mvcBloggyReCaptchaPrivateKey"

# Helper Functions
function set-connectionstring {
    param($path, $name, $value)
    $decodedValue = [System.Web.HttpUtility]::HtmlDecode($value)
    $settings = [xml](get-content $path)
    $setting = $settings.configuration.connectionStrings.add | where { $_.name -eq $name }
    $setting.connectionString = "$decodedValue"
    $resolvedPath = resolve-path($path) 
    $settings.save($resolvedPath)
}

function set-appsetting {
    param($path, $name, $value)
    $settings = [xml](get-content $path)
    $setting = $settings.configuration.appSettings.selectsinglenode("add[@key='" + $name + "']")
    $setting.value = $value.toString()
    $resolvedPath = resolve-path($path)
    $settings.save($resolvedPath)
}

function set-releasemode {
    param($path)
    $xml = [xml](get-content $path)
    $compilation = $xml.configuration."system.web".compilation
    $compilation.debug = "false"
    $resolvedPath = resolve-path($path) 
    $xml.save($resolvedPath)
}

function set-customerrorson { 
    param($path)
    $xml = [xml](get-content $path)
    $customErrors = $xml.configuration."system.web".customErrors
    $customErrors.mode = "On"
  	$resolvedPath = resolve-path($path) 
  	$xml.save($resolvedPath)
}

function remove-specifiedPickupDirectory { 
    param($path)
    $xml = [xml](get-content $path)
    $mailSettings = $xml.configuration."system.net".mailSettings
    $smtp = $mailSettings.smtp
    if($smtp.specifiedPickupDirectory -ne $null) { 
        $smtp.removechild($smtp.specifiedPickupDirectory) | out-null
        $resolvedPath = resolve-path($path)
        $xml.save($resolvedPath)
    }
}

function set-deliveryMethodAsNetwork {
    param($path)
    $xml = [xml](get-content $path)
    $mailSettings = $xml.configuration."system.net".mailSettings
    $smtp = $mailSettings.smtp
    $smtp.deliveryMethod = "Network"
    $resolvedPath = resolve-path($path)
    $xml.save($resolvedPath)
}

function set-emailsettings {
    param($path, $emailHost, $emailUserName, $emailPassword, $smtpPort)
    $xml = [xml](get-content $path)
    $mailSettings = $xml.configuration."system.net".mailSettings
    $smtpNetwork = $mailSettings.smtp.network

    if($smtpNetwork.host -eq $null) { 
        $smtpNetworkHostAttr = $xml.CreateAttribute("host")
        $smtpNetwork.SetAttributeNode($smtpNetworkHostAttr) | out-null
    }
    if($smtpNetwork.port -eq $null) { 
        $smtpNetworkPortAttr = $xml.CreateAttribute("port")
        $smtpNetwork.SetAttributeNode($smtpNetworkPortAttr) | out-null
    }
    if($smtpNetwork.userName -eq $null) { 
        $smtpNetworkUserNameAttr = $xml.CreateAttribute("userName")
        $smtpNetwork.SetAttributeNode($smtpNetworkUserNameAttr) | out-null
    }
    if($smtpNetwork.password -eq $null) { 
        $smtpNetworkPasswordAttr = $xml.CreateAttribute("password")
        $smtpNetwork.SetAttributeNode($smtpNetworkPasswordAttr) | out-null
    }

    $smtpNetwork.host = $emailHost
    $smtpNetwork.port = $smtpPort
    $smtpNetwork.userName = $emailUserName
    $smtpNetwork.password = $emailPassword
    $resolvedPath = resolve-path($path)
    $xml.save($resolvedPath)
}

$scriptPath = split-path $MyInvocation.MyCommand.Path
$rootPath = resolve-path(join-path $scriptPath "..")
$artifactsPath = join-path $rootPath "artifacts"
$webAppsPath = join-path $artifactsPath "_PublishedWebsites"
$webProjectPath = join-path $webAppsPath "MvcBloggy.Web"
$webProjectConfigPath = join-path $webProjectPath "web.config"
$gitPath = join-path (programfiles-dir) "Git\bin\git.exe"

$deploymentLabel = "$((get-date).ToString("MMM dd @ HHmm"))"
$deploymentName = "$((get-date).ToString("yyyyMMddHHmmss"))-auto"
$commitSha = (& "$gitPath" rev-parse HEAD)
$commitBranch = (& "$gitPath" name-rev --name-only HEAD)

# Make config changes here
set-connectionstring -path $webProjectConfigPath -name "MvcBloggy" -value $mvcBloggyDbSqlConnectionString
set-appsetting $webProjectConfigPath "MvcBloggy:CommitSha" $commitSha
set-appsetting $webProjectConfigPath "MvcBloggy:CommitBranch" $commitBranch
set-appsetting $webProjectConfigPath "MvcBloggy:DeploymentName" $deploymentName
set-appsetting $webProjectConfigPath "recaptcha-public-key" $mvcBloggyReCaptchaPublicKey
set-appsetting $webProjectConfigPath "recaptcha-private-key" $mvcBloggyReCaptchaPrivateKey
set-releasemode $webProjectConfigPath
set-customerrorson $webProjectConfigPath
remove-specifiedPickupDirectory $webProjectConfigPath
set-deliveryMethodAsNetwork $webProjectConfigPath
set-emailsettings -path $webProjectConfigPath -emailHost $mvcBloggyEmailHost -emailUserName $mvcBloggyEmailUsername -emailPassword $mvcBloggyEmailPassword -smtpPort $mvcBloggyEmailPort

# Deploy
$fullMsDeployComputerName = "{0}?site={1}" -f $msDeployServerName, $msDeployWebsiteName
& "C:\Program Files\IIS\Microsoft Web Deploy v3\msdeploy.exe" -verbose -verb:sync "-source:contentpath='$webProjectPath'" "-dest:contentPath='$msDeployWebsiteName',computerName='$fullMsDeployComputerName',userName='$msDeployUserName',password='$msDeployPassword',authtype='basic',includeAcls='False'" -allowUntrusted