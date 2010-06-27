#!/bin/sh
for file in $(git diff --cached --name-only | grep .cs); do
	echo "filename: $file"
done
