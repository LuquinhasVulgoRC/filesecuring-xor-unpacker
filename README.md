# filesecuring-xor-unpacker
Um deobfuscador estático para esse ofuscador Lua denominado "filesecuring" / "xor".
Este ofuscador era usado principalmente em comunidades FiveM, devido à maneira como ele detecta load = print, era muito difícil descartá-lo conectando funções lua.
Recentemente, eles descontinuaram e abriram o código-fonte de seu ofuscador, para que eu possa liberar publicamente meu desofuscador para ele.

Uso:
execute CLI.exe com os seguintes argumentos:

`CLI.exe input.lua`

Isso vai criar um `input_unpacked.lua` no mesmo diretório
⚠️ Pode demorar um pouco para decodificar scripts maiores do que 10 MB, seja paciente
Este ofuscador foi feito por Federal#9999 e traduzido por Citizen.RC(-1)#2115, sinta-se à vontade para editalo.
Uma coisa os arquivos ja estão compilados dentro da pasta bin dos respectivos arquivos denominados CLI e XOR Unpacker para quem não sabe compilar .sln (RC escreveu isso '-')