﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Prj
{
    delegate int Arithmetic(int x, int y);
        class delegateasParameter
    {
        static void Main()
        {
            DoOperation(10, 2, Multiply);
            DoOperation(10, 2, Divide);
            Console.Read();

        }

        static void DoOperation(int x, int y, Arithmetic amdel)
        {
            int z = amdel(x, y);
            Console.WriteLine(z);
            
        }

        static int Multiply(int x, int y)
        {
            return x * y;
        }

        static int Divide(int x, int y)
        {
            return x / y;
        }
    }
}
