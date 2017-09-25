using System;

namespace Day_3_of_Code {
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
        int maxnumberOfPeapleInCar = 6;

        public Car() {

        }

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
            if (numberOfPeopleInCar < maxnumberOfPeapleInCar) {
                numberOfPeopleInCar++;
                Console.WriteLine("Someone got in!");
            }
            else {
                Console.WriteLine("Car is full: " + numberOfPeopleInCar + " = " + maxnumberOfPeapleInCar);
            }
        }

        public void getOut() {
            if (numberOfPeopleInCar > 0) {
                numberOfPeopleInCar--;
                Console.WriteLine("Someone got out!");
            }
            else {
                Console.WriteLine("Car is empty: " + numberOfPeopleInCar + " = 0");
            }
        }

        public double howManyMilesTillOutOfGas() {
            return currentFuel * mpg;
        }

        public double maxMilesPerFillUp() {
            return maxFuel * mpg;
        }

        public void turnCarOnOffToggle() {
            if (!isTheCarOn) {
                isTheCarOn = true;
                Console.WriteLine("The car was off and now turned on!");
            }
            else {
                isTheCarOn = false;
                Console.WriteLine("The car was on and now turned off!");
            }
        }
    }
}
