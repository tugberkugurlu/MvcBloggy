#http://msdn.microsoft.com/en-us/library/vstudio/ms164311.aspx

param(
    $buildFile   = (join-path (Split-Path -parent $MyInvocation.MyCommand.Definition) "MvcBloggy.msbuild"),
    $buildParams = "/p:Configuration=Release",
    $buildTarget = "/t:Default"
)

& "$(get-content env:windir)\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe" $buildParams $buildTarget $buildFile /flp1:"Verbosity=normal;Encoding=UTF-8;LogFile=$env:TEMP\mvcbloggy_build_log_$((get-date).ToString("yyyyMMddHHmmss")).txt"