
rem @echo off

set H=R:\KSP_1.3.1_dev
set GAMEDIR=000_FilterExtensions
set GAMEDIR2="000_FilterExtensions_Configs"
set GAMEDATA="GameData\"
set VERSIONFILE=%GAMEDIR%.version

echo %H%

copy /Y "%1%2" "GameData\%GAMEDIR%\Plugins"


xcopy  /y /s /I  %GAMEDATA%\%GAMEDIR% "%H%\GameData\%GAMEDIR%"

xcopy  /y /s /I   %GAMEDATA%\%GAMEDIR2% "%H%\GameData\%GAMEDIR2%"
