Write-Host "Starting nexus ..." -foregroundcolor Blue -backgroundcolor White

Write-Host "Get nexus image ..." -foregroundcolor Blue -backgroundcolor White

docker pull sonatype/nexus

Write-Host "Get nexus image ...Done" -foregroundcolor Blue -backgroundcolor White

Write-Host "Starting sonarqube container ..." -foregroundcolor Blue -backgroundcolor White

docker run -d -p 8081:8081 --name nexusServer sonatype/nexus

Write-Host "Starting nexus container ...Done" -foregroundcolor Blue -backgroundcolor White
