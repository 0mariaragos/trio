using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    class Program
    {C:\Users\aluno3\Desktop\trio\teste\Program.cs
        public static int somar(int valor1, int valor2)
        {
            return valor1 + valor2;
        }
        public static int subtrair(int valor1, int valor2)
        {
            return valor1 - valor2;
        }
        public static int multiplicar(int valor1,int valor 2)
        {
            return valor1 * valor2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("O resultado da soma: {0} + {1} = {2}", 3, 5, somar(3, 5));

            Console.WriteLine("O resultado da subtração: {0} + {1} = {2}", 3, 5, subtrair(3, 5));
        }
    }
}
