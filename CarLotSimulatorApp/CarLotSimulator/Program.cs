using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            CarLot cars = new CarLot();
            cars.CarList = new List<Car>();

            Car c1 = new Car();
                  
            c1.Make = "Tesla";
            c1.Model = "Y";
            c1.Year = 2019;
            c1.EngineNoise = "No";
            c1.HonkNoise = "Yes";
            c1.IsDrivable = true;

            cars.CarList.Add(c1);

            
            Car c2 = new Car()
            {

            Make = "Audi",
            Model = "Q5",
            Year = 2021,
            EngineNoise = "Yes",
            HonkNoise = "Yes",
            IsDrivable = true
        };
            cars.CarList.Add(c2);
            Car c3 = new Car("Lexus","RX",2021,"No","Yes",true);

            cars.CarList.Add(c3);
            Console.WriteLine($"{c1.Make}\n-----------\n");
            c1.MakeEngineNoise(c1.EngineNoise);
            c1.MakeHonkNoise(c1.HonkNoise);

            Console.WriteLine($"{c2.Make}\n-----------\n");

            c2.MakeEngineNoise(c2.EngineNoise);
            c2.MakeHonkNoise(c2.HonkNoise);

            Console.WriteLine($"{c3.Make}\n-----------\n ");

            c3.MakeEngineNoise(c3.EngineNoise);
            c3.MakeHonkNoise(c3.HonkNoise);
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console


            foreach (var car in cars.CarList)
            {
                Console.WriteLine($"\n\nCars\n-------------------\nCar Make: {car.Make}\nCar Model: {car.Model}\nCar Built Year: {car.Year}\nEngineNoise: {car.EngineNoise}\nHonkNoise: {car.HonkNoise}");
            }
        }
    }
}
