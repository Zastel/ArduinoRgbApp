#!/bin/bash
foldersToRemove=$(find . -name bin -o -name obj)
if [[ $foldersToRemove != "" ]]; then
    echo "Removing folders:"
    echo "$foldersToRemove"
    rm -rf `find . -name bin -o -name obj`
else
    echo "No bin or obj folders to remove"
fi