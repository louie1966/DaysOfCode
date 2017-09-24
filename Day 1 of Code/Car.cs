using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1_of_Code {
    public class Car {

        int maxSpeed = 100;
        int minSpeed = 0;
        double weight = 1000;
        bool isTheCarOn = false;
        char condition = 'A';
        String nameOfCar = "Lucy";

        public void printVariables() {
            Console.WriteLine("This is the maximum speed: " + maxSpeed);
            Console.WriteLine(minSpeed);
            Console.WriteLine(weight);
            Console.WriteLine(isTheCarOn);
            Console.WriteLine(condition);
            Console.WriteLine(nameOfCar);
        }

        public void upgradeMinSpeed() {
            minSpeed = maxSpeed;
            maxSpeed++;
        }
    }
}
