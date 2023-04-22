﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio04
{
    public class Ejercicio02
    {
        public double[] Calcular(int[] nums)
        {
            double suma = 0;
            double promedio = 0;

            if (nums.Length > 0)
            {
                foreach (int num in nums)
                {
                    suma += num;
                }

                promedio = suma / nums.Length;
            }

            return new double[] { suma, promedio };

        }
    }
}
