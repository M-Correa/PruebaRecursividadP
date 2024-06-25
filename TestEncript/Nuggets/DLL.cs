using System;
using TestEncript.Nuggets;

namespace TestEncript
{
    class DLL 
    {
        public string Encrypt(string text)
        {
            Punto1 item = new Punto1();
            string textoEncriptado = item.Encrypt(text);

            Punto2Helper item2 = new Punto2Helper();
            Punto2 API = item2.CrearPunto2();
            string textoEncriptadoDos = API.Encrypt(textoEncriptado);

            Punto3 item3 = new Punto3();
            string textoEncriptadotres = item3.Encrypt(textoEncriptadoDos);

            return textoEncriptadotres;
        }


        public string Decrypt(string text)
        {
            Punto1 item = new Punto1();
            string textoEncriptado = item.Decrypt(text);

            Punto2Helper item2 = new Punto2Helper();
            Punto2 API = item2.CrearPunto2();
            string textoEncriptadoDos = API.Decrypt(textoEncriptado);

            Punto3 item3 = new Punto3();
            string textoEncriptadotres = item3.Decrypt(textoEncriptadoDos);

            return textoEncriptadotres;
        }
    }
}
