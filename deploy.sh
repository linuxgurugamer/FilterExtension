#!/bin/bash

DEV="/home/cameron/src/FilterExtension"
KSP="/mnt/games/KSPDev"

GAMEDIR="000_FilterExtensions"
GAMEDIR2="000_FilterExtensions_Configs"
GAMEDATA="GameData/"

cp "$1$2" "$DEV/GameData/$GAMEDIR/Plugins"
cp "$DEV/FilterExtension.version" "$DEV/GameData/$GAMEDIR/"

cp -r "$DEV/$GAMEDATA/$GAMEDIR" "$KSP/GameData/"
cp -r "$DEV/$GAMEDATA/$GAMEDIR2" "$KSP/GameData/"