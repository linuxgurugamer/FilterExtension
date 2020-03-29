#!/bin/bash

[ "$3" != "Release" ] || exit

DEV="/home/cameron/src/FilterExtension"

GAMEDIR="000_FilterExtensions"
GAMEDIR2="000_FilterExtensions_Configs"
LICENSE="License.txt"
README="ReadMe.txt"

RELEASEDIR="$DEV/release"
mkdir -p "$RELEASEDIR"

cp "$1$2" "$DEV/GameData/$GAMEDIR/Plugins/"

cp "$DEV/FilterExtension.version" "$DEV/GameData/$GAMEDIR/"
# cp "$DEV/../MiniAVC.dll" "$DEV/GameData/$GAMEDIR" # ??

cp "$DEV/$LICENSE" "$DEV/GameData/$GAMEDIR"
cp "$DEV/$README" "$DEV/GameData/$GAMEDIR"

VERSIONFILE="$DEV/FilterExtension.version"
VMA=`jq ".VERSION.MAJOR" $VERSIONFILE`
VMI=`jq ".VERSION.MINOR" $VERSIONFILE`
PA=`jq ".VERSION.PATCH" $VERSIONFILE`
BU=`jq ".VERSION.BUILD" $VERSIONFILE`
VERSION="$VMA.$VMI.$PA.$BU"

echo "Version: $VERSION"

cd "$DEV"
rm "$RELEASEDIR/$GAMEDIR-$VERSION.zip"
zip -r "$RELEASEDIR/$GAMEDIR-$VERSION.zip" "GameData"