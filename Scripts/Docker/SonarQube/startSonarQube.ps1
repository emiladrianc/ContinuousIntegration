Write-Host "Starting sonarqube ..." -foregroundcolor Blue -backgroundcolor White

Write-Host "Get sonarqube image ..." -foregroundcolor Blue -backgroundcolor White

docker pull sonarqube

Write-Host "Get sonarqube image ...Done" -foregroundcolor Blue -backgroundcolor White

Write-Host "Starting sonarqube container ..." -foregroundcolor Blue -backgroundcolor White

docker run -d --name sonarQubeServer -p 9000:9000 -p 9092:9092 sonarqube

Write-Host "Starting sonarqube container ...Done" -foregroundcolor Blue -backgroundcolor White
