Write-Host "Starting jenkins ..." -foregroundcolor Blue -backgroundcolor White

$jenkinsImageVersion = "2.46.2"
$jenkinsPort = "8079"

Write-Host "Get jenkins image:" $jenkinsImageVersion " ..." -foregroundcolor Blue -backgroundcolor White

docker pull jenkins:$jenkinsImageVersion

Write-Host "Get jenkins image:" $jenkinsImageVersion " ...Done" -foregroundcolor Blue -backgroundcolor White

Write-Host "Creating my jenkins image ..." -foregroundcolor Blue -backgroundcolor White

docker build ./image -t myjenkins

Write-Host "Creating my jenkins image ...Done" -foregroundcolor Blue -backgroundcolor White

Write-Host "Starting my jenkins container on port:" $jenkinsPort "..." -foregroundcolor Blue -backgroundcolor White

$runJenkinsInstruction = "docker run -d --name myJenkinsServer -p " + $jenkinsPort + ":8080 -p 50000:50000 myjenkins"
Write-Host "Command:" $runJenkinsInstruction

Invoke-Expression $runJenkinsInstruction

Write-Host "Starting my jenkins container on port:" $jenkinsPort "...Done" -foregroundcolor Blue -backgroundcolor White
