using System;
using System.IO;
using XOR_Unpacker;


namespace CLI {
    class Program {
        static void Main(string[] args) {
            Debug.Log("XOR Deobfuscator by Federal#9999 traduzido por Citizen.RC(-1)#2115 v1.0", ConsoleColor.Cyan);
            Debug.Log("[1/7] Iniciando..");
            string script = File.ReadAllText(args[0]);
            script = Unpacker.UnpackXORScript(script);
            Debug.Log("[6/7] Finalizando..", ConsoleColor.White);
            string @out = Path.GetFileNameWithoutExtension(args[0]) + "_unpacked.lua";
            File.WriteAllText(@out, script);
            Debug.Log($"[7/7] Deobfuscado e salvo em {@out}", ConsoleColor.Green);
            
        }
    }
}
