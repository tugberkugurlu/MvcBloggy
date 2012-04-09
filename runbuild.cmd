powershell -Command "& {Import-Module .\tools\PSake\psake.psm1; Invoke-psake .\build.ps1 %*}"
pause