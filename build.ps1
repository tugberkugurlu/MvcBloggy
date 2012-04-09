Properties { 
    $base_dir = Resolve-Path .
    $sln_file = "$base_dir\MvcBloggy.sln"
    $output_dir = "$base_dir\Output\"
    $output_bin_dir = "$base_dir\Output\Binaries\"
    $website_output_dir = "$base_dir\Output\Web\"
}

Task default -depends Compile

Task Compile -Depends Clean {
   Write-Output "compile Task is running..."
   
   msbuild $sln_file /t:Rebuild /p:Configuration=Release /p:OutDir=$output_bin_dir /p:WebProjectOutputDir=$website_output_dir
}

# Ensure a clean working directory
Task Clean {
    Write-Output "Clean Task is running..."
    
    if (Test-Path -path $output_dir) 
    {
        Write-Output "Deleting Output Directory"
        del $output_dir -Recurse -Force
    }
   
    New-Item -Path $output_dir -ItemType Directory
}