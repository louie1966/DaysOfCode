using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2_of_Code {
    public class Car {

        int maxSpeed = 100;
        int minSpeed = 0;

        double weight = 4079;

        bool isTheCarOn = false;
        char condition = 'A';
        String nameOfCar = "Lucy";

        double maxFuel = 16;
        double currentFuel = 8;
        double mpg = 26.4;

        int numberOfPeopleInCar = 1;

        public Car(int customMaxSpeed, double customWeight, bool customIsTheCarOn) {
            maxSpeed = customMaxSpeed;
            weight = customWeight;
            isTheCarOn = customIsTheCarOn;
        }

        public void printVariables() {
            Console.WriteLine("This is the maximum speed: " + maxSpeed);
            Console.WriteLine("This is the minimum speed: " + minSpeed);
            Console.WriteLine("This is the weight: " + weight);
            Console.WriteLine("This tells if the car is on: " + isTheCarOn);
            Console.WriteLine("This is the condition: " + condition);
            Console.WriteLine("This is the name: " + nameOfCar);
            Console.WriteLine("This is the number of people: " + numberOfPeopleInCar);
        }

        public void upgradeMinSpeed() {
            minSpeed = maxSpeed;
            maxSpeed++;
        }

        public void getIn() {
            //numberOfPeopleInCar = numberOfPeopleInCar + 1;
            numberOfPeopleInCar++;
        }

        public void getOut() {
            //numberOfPeopleInCar = numberOfPeopleInCar - 1;
            numberOfPeopleInCar--;
        }

        public double howManyMilesTillOutOfGas() {
            return currentFuel * mpg;
        }

        public double maxMilesPerFillUp() {
            return maxFuel * mpg;
        }
    }
}
