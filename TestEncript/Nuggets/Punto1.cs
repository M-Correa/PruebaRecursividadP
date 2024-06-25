using System;

namespace TestEncript
{
    class Punto1 : ISecurityElement
    {

      
        public string Decrypt(string text)
        {
            return StrReverse(text);
        }
        private string StrReverse(string text)
        {
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public string Encrypt(string text)
        {
            return StrReverse(text);
        }
    }
}
