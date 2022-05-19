using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_16_Multiplicity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lowlimitMultiples = 100;
            int highlimitMultiples = 1000;
            int numbersMultiples = 0;

            int lowDiapasoneDivider = 1;
            int highDiapasoneDivider = 28;

            Random random = new Random();
            int randomDivider = random.Next(lowDiapasoneDivider, highDiapasoneDivider);

            for (int i = randomDivider; i < highlimitMultiples; i += randomDivider)
            {
                if (i >= lowlimitMultiples)
                    numbersMultiples++;
            }

            Console.WriteLine(numbersMultiples);
        }
    }
}
