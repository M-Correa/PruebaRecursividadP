using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEncript.Nuggets
{
    class Punto2Helper
    {
        public Punto2Helper()
        {

        }
        public Punto2 CrearPunto2()
        {
            Func<int, int> encryptFunc = x => (x + 2);
            Func<int, int> decryptFunc = x => (x - 2);

            Punto2 item2 = new Punto2(encryptFunc, decryptFunc);
            return item2;
        }
    }
}
