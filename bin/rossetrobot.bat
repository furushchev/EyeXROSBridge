@echo off

set uri=%1
set ip=%2
if "%3" neq "" goto ERROR

if "%uri%" == "" goto LOCAL_URI
:CONT
if "%ip%" == "" goto LOCAL_IP

:SETX
@setx ROS_MASTER_URI %uri%
echo ROS_MASTER_URI="%uri%"
@setx ROS_IP "%ip%"
@setx ROS_HOSTNAME %ip%
echo ROS_IP,ROS_HOSTNAME = "%ip%"
goto :EOF

:LOCAL_URI
set /p luri="ROS_MASTER_URI?: "
if "%luri%" neq "" (
set uri=http://%luri%:11311/
) else (
set uri=http://localhost:11311/
)
goto :CONT

:LOCAL_IP
set /p ip="ROS_IP?; "
if "%ip%" neq "" goto :SETX
set ip=localhost
goto :SETX

:ERROR
echo Error: Invalid arguments!
echo USAGE:
echo rossetrobot <ROS_MASTER_URI> <ROS_IP>
echo e.g.:
echo rossetrobot pr1012
echo rossetrobot pr1012 133.11.216.42
pause
goto :EOF
