#!/bin/bash

filename=$1
search_word=$2

cat "$filename" | grep -i --color=auto -C 2 "$search_word" | less


# Make the script executable./search.sh document.txt your_word
# chmod +x search.sh  
