using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat2020._09._29
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            
            
            
            
            //üzemanyag

            Console.WriteLine("utazási költségtérités");
            Console.Write("Add meg a megtett utat km-ben! ");
            double ut = Convert.ToDouble(Console.ReadLine());
            Console.Write("Add meg az autó fogyaztását 100 km-re literben! ");
            double fogyasztas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Add meg az üzemanyaárat FT-ban! ");
            double uzemanyag = Convert.ToDouble(Console.ReadLine());
            
            if (ut <= 100)
            {
                Console.Write("üzemanyagköltség " + (ut * fogyasztas * uzemanyag) / 100);
            }
            else
            {

                Console.WriteLine("költségtérités "+((ut*25)*fogyasztas*uzemanyag));
                 
            }
            //testtömeg

            Console.WriteLine("hány kg vagy?");

            double kg = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("hány cm vagy ?"  );

            double cm = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("TTI "+kg/(cm/100*cm/100));

            Console.ReadKey();
        }
    }
}
