using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestEncript.Nuggets;

namespace TestEncript
{
    class MAIN
    {
        static void Main(string[] args)
        {
            DLL item = new DLL();
            Console.Write("Ingrese el texto Punto1 : ");
            string textoOriginal = Console.ReadLine();
            string encriptado = item.Encrypt(textoOriginal);

            Console.WriteLine($"Texto encriptado : {encriptado}");

            string desencriptado = item.Decrypt(textoOriginal);
            Console.WriteLine($"Texto desencriptado : {desencriptado}");
        }

    }
}
