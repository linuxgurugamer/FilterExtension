
@echo off

set H=%KSPDIR%
set GAMEDIR=000_FilterExtensions
set GAMEDIR2="000_FilterExtensions_Configs"
set GAMEDIR3="zFinal_FilterExtensions"
set GAMEDATA="GameData"
set VERSIONFILE=FilterExtension.version

echo %H%
set DP0=r:\dp0\kspdev

copy /Y "%1%2" "%GAMEDATA%\%GAMEDIR%\Plugins"
copy /Y %VERSIONFILE% %GAMEDATA%\%GAMEDIR%


xcopy  /y /s /I  %GAMEDATA%\%GAMEDIR% "%H%\GameData\%GAMEDIR%"
copy /Y "%1%3".pdb "%GAMEDATA%\%GAMEDIR%\Plugins"

xcopy  /y /s /I   %GAMEDATA%\%GAMEDIR2% "%H%\GameData\%GAMEDIR2%"
xcopy  /y /s /I   %GAMEDATA%\%GAMEDIR3% "%H%\GameData\%GAMEDIR3%"

