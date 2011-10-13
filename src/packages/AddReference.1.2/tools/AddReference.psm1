#Mostly done by @dfowler.

function AddReference($project) {
    $ref = $project.Object.References | Where-Object { $_.Name -eq $referenceName }
    if(!$ref) {
        if($project.Type -eq 'Web Site') {
            $project.Object.References.AddFromGAC($referenceName) | Out-Null
        }
        elseif($project.Type -eq 'F#') {
            $project.Object.References.Add("*$referenceName") | Out-Null
        }
        else {
            $project.Object.References.Add($referenceName) | Out-Null
        }
        "Successfully added reference to '$($project.Name)'"
    }
    else {
        Write-Warning "Reference $referenceName already exists in your project..."
    }
}

function RemoveReference($project, $referenceName) {
    $project.Object.References | Where-Object { $_.Name -eq $referenceName } | ForEach-Object { $_.Remove() }
}

function ResolveProjects($projectName) {
    if($projectName) {
        Get-Project $projectName
    }
    else {
        Get-Project
    }
}

function Add-Reference {
    param(
        [parameter(position = 0, mandatory=$true)]
        [string]$ReferenceName,
        [parameter(position = 1, ValueFromPipelineByPropertyName = $true)]
        [string[]]$ProjectName
    )
    Process {
        (ResolveProjects $ProjectName) | %{ AddReference $_ $ReferenceName }
    }
}

function Remove-Reference {
    param(
        [Parameter(position=0, mandatory=$true)]
        [string]$ReferenceName,
        [parameter(position = 1, ValueFromPipelineByPropertyName = $true)]
        [string[]]$ProjectName
    )
    Process {
        (ResolveProjects $ProjectName) | %{ RemoveReference $_ $ReferenceName }
    }
}

Register-TabExpansion 'Add-Reference' @{
    'ProjectName' = { Get-Project -All | Select -ExpandProperty Name }
}

Register-TabExpansion 'Remove-Reference' @{
    'ReferenceName' = {param($context)
        if($context.ProjectName) {
            $project = Get-Project $context.ProjectName
        }
        
        if(!$project) {
            $project = Get-Project
        }
        
        $project.Object.References | Sort Name | %{ $_.Name } | Select -Unique
    }
    'ProjectName' = { Get-Project -All | Select -ExpandProperty Name }
}

Export-ModuleMember Add-Reference, Remove-Reference