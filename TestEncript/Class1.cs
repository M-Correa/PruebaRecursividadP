using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEncript
{
    class Punto3 : ISecurityElement
    {
        private int _salto=0;
        public Punto3()
        {
        }
        public string Decrypt(string text)
        {
            _salto = (int)text.Last();
            return DecryptRecursive(text, 0);
        }

        private string DecryptRecursive(string text,int indice)
        {
            if (indice > text.Length) { 
                return string.Empty;
            }
            char Desencriptado = (char)(( (int)(text[indice]) + _salto + 256) % 256);
            return Desencriptado + EncryptRecursive(text, indice + 1);
        }
        private string EncryptRecursive(string text, int indice)
        {
            if (indice >= text.Length)
            {
                return _salto.ToString();
            }
            char encriptado = (char)(((int)(text[indice]) - _salto + 256) % 256);
            return encriptado + EncryptRecursive(text, indice + 1);
        }
        public string Encrypt(string text)
        {
            _salto = text.Count(x => x == 'a');
            return EncryptRecursive(text,0);
        }
    }
}
