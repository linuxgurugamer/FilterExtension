
@echo off

set H=R:\KSP_1.5.1_dev
set GAMEDIR=000_FilterExtensions
set GAMEDIR2="000_FilterExtensions_Configs"
set GAMEDIR3="zFinal_FilterExtensions"
set GAMEDATA="GameData\"
set VERSIONFILE=FilterExtension.version

echo %H%

copy /Y "%1%2" "GameData\%GAMEDIR%\Plugins"
copy /Y %VERSIONFILE% %GAMEDATA%\%GAMEDIR%


xcopy  /y /s /I  %GAMEDATA%\%GAMEDIR% "%H%\GameData\%GAMEDIR%"

xcopy  /y /s /I   %GAMEDATA%\%GAMEDIR2% "%H%\GameData\%GAMEDIR2%"
xcopy  /y /s /I   %GAMEDATA%\%GAMEDIR3% "%H%\GameData\%GAMEDIR3%"
