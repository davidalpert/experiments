#!/bin/sh
fileList=""
pwd=$(pwd)
for file in $(git diff --cached --name-only | grep .cs); do
	fileList="$pwd/$file $fileList"
done
echo "files: $fileList"
~/bin/styleCopCmd-bin-0.2.1.0/Net.SF.StyleCopCmd.Console/stylecopCmd.exe -f $fileList
