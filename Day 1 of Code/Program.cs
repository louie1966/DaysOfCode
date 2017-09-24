using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1_of_Code {
   class Program {  


        static void Main(string[] args) {
            Car familyCar = new Car();
            Console.WriteLine("Family car:");
            familyCar.printVariables();
            Console.WriteLine();            
            familyCar.upgradeMinSpeed();            
            familyCar.printVariables();
            Console.WriteLine();

            // Keeps console window open
            Console.ReadKey();
        }
    }
}
