using System;

namespace TestEncript
{
    class Punto2 : ISecurityElement
    {
        private readonly Func<int, int> _encryptFunc;
        private readonly Func<int, int> _decryptFunc;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public Punto2(Func<int, int> encryptFunc, Func<int, int> decryptFunc)
        {
            _encryptFunc = encryptFunc ?? throw new ArgumentNullException(nameof(encryptFunc));
            _decryptFunc = decryptFunc ?? throw new ArgumentNullException(nameof(decryptFunc));
        }
        public string Decrypt(string text)
        {
            char[] resultado = new char[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                int codigoEncriptado = (int)text[i]; // Codigo ascii
                int codigoOriginal = _decryptFunc(codigoEncriptado);
                resultado[i] = (char)codigoOriginal;
            }
            return new string(resultado);
        }

        public string Encrypt(string text)
        {
            char[] resultado = new char[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                int codigoOriginal = (int)text[i];
                int codigoEncriptado = _encryptFunc(codigoOriginal);
                resultado[i] = (char)codigoEncriptado;
            }
            return new string(resultado);
        }
    }
}