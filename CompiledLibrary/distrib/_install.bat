echo off
echo Deploying project DIFFWIZ
IF EXIST MCRInstaller.exe (
echo Running MCRInstaller
MCRInstaller.exe
)

echo Installation complete.
echo Please refer to the documentation for any additional setup steps.