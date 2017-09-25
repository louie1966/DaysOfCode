using System;

namespace Day_2_of_Code {
    class Program {  


        static void Main(string[] args) {
            Car birthDayPresent = new Car(500, 5000.545, true);
            Console.WriteLine("Birthday Car v1");
            birthDayPresent.printVariables();
            Console.WriteLine();

            birthDayPresent.getIn();
            birthDayPresent.getIn();
            birthDayPresent.getIn();
            Console.WriteLine("Miles left: " + birthDayPresent.howManyMilesTillOutOfGas());
            Console.WriteLine("Max milage: " + birthDayPresent.maxMilesPerFillUp());
            Console.WriteLine();

            Console.WriteLine("Birthday Car v2");
            birthDayPresent.printVariables();
            Console.WriteLine();

            birthDayPresent.getOut();
            Console.WriteLine("Birthday Car v3");
            birthDayPresent.printVariables();

            Console.WriteLine();
            //Car christmasPresent = new Car(550, 2000, false);
            //Console.WriteLine("Christmas Car");
            //christmasPresent.printVariables();
            //Console.WriteLine();

            // Keeps console window open
            Console.ReadKey();
        }
    }
}
