REM 1. Copy the exe to program files with a folder
mkdir c:\GoUtility\
copy Go.* C:\GoUtility\
copy SettingRegistryAppPaths.reg C:\GoUtility\

REM 2. Copy the COnfig file to users folder
copy App.config C:\GoUtility\
xcopy \Configurations "C:\GoUtility\Configurations" /c /d /e /h /i /k /q /r /s /x /y

REM 3. add registry editor
regedit.exe /S "C:\GoUtility\SettingRegistryAppPaths.reg"

REM 4. Remove registry editing file
del "C:\GoUtility\SettingRegistryAppPaths.reg"

