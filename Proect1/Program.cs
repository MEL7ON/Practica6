using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proect1
{
  internal class Programm
   {
    static void Main(string[] args)
    {
            double x, y;
            Console.Write("Введите x: ");
            x = Convert.ToDouble(Console.ReadLine());
            y = (Math.Sin(x) - Math.Cos(x))/5;
    }
   }
}

