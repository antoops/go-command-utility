REM Set the current directory
PUSHD "%~dp0"
Echo Current dir: "%CD%"
REM 1. Copy the exe to program files with a folder
mkdir c:\GoUtility\
xcopy *.* "c:\GoUtility\" /c /d /e /h /i /k /q /r /s /x /y

REM 2. add registry editor
regedit.exe /S "C:\GoUtility\SettingRegistryAppPaths.reg"

REM 3. Remove registry editing file
del "C:\GoUtility\SettingRegistryAppPaths.reg"

