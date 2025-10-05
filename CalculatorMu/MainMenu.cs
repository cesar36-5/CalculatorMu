using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorMu
{
    internal class MainMenu
    {
        public void ShowMenu()
        {
            Console.WriteLine("Que desea hacer?");
            Console.WriteLine("1) Suma");
            Console.WriteLine("2) Resta");
            Console.WriteLine("3) Multiplicacion");
            Console.WriteLine("4) Division");

            Console.ReadLine();
        }
    }
}
