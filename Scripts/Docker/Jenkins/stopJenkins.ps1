Write-Host "Stopping my jenkins container: ..." -foregroundcolor Blue -backgroundcolor White

docker stop myJenkinsServer

Write-Host "Stopping my jenkins container: ...Done" -foregroundcolor Blue -backgroundcolor White

Write-Host "Deleting my jenkins container: ..." -foregroundcolor Blue -backgroundcolor White

docker rm myJenkinsServer

Write-Host "Deleting my jenkins container: ...Done" -foregroundcolor Blue -backgroundcolor White

Write-Host "Deleting my jenkins image: ..." -foregroundcolor Blue -backgroundcolor White

docker rmi myjenkins

Write-Host "Deleting my jenkins image: ...Done" -foregroundcolor Blue -backgroundcolor White
