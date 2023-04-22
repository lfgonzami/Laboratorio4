using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio04
{
    public class Ejercicio03
    {
        public string Sumar(string num1, string num2) 
        {
            BigInteger suma = 0;
            BigInteger.TryParse(num1, out BigInteger num3);
            BigInteger.TryParse(num2, out BigInteger num4);
            suma = num3 + num4;
            return suma.ToString();
        }
    }
}
