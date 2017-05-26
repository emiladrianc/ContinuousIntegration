Write-Host "Stopping sonarqube container ..." -foregroundcolor Blue -backgroundcolor White

docker stop sonarQubeServer

Write-Host "Stopping sonarqube container ...Done" -foregroundcolor Blue -backgroundcolor White

Write-Host "Deleting sonarqube container ..." -foregroundcolor Blue -backgroundcolor White

docker rm sonarQubeServer

Write-Host "Deleting sonarqube container ...Done" -foregroundcolor Blue -backgroundcolor White

