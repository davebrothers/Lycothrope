COPY Lycothrope.Forms.exe temp.exe
..\..\..\..\packages\ILMerge.2.14.1208\tools\ILMerge.exe /out:Lyco.exe temp.exe Lycothrope.dll
DEL temp.exe