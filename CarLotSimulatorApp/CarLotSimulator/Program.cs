using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            var lot = new CarLot();
            

            //DONE - Create a seperate class file called Car
            //DONE - Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //DONE - Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //DONE - The methods should take one string parameter: the respective noise property


            //DONE - Now that the Car class is created we can instanciate 3 new cars
            //DONE - Set the properties for each of the cars
            //DONE - Call each of the methods for each car

            //Instantiation 1 "Using Dot Notation"
            var ryansCar = new Car();
            ryansCar.Make = "Ford";
            ryansCar.Model = "Focus";
            ryansCar.Year = 2013;
            ryansCar.EngineNoise = "vroom";
            ryansCar.HonkNoise = "beep";
            ryansCar.IsDrivable = true;

            //add ryansCar to the carlot
            lot.Cars.Add(ryansCar);

            //Instantiation 2 "Object Initializer Syntax"
            var stevesCar = new Car()
            {
                Year = 2019,
                Make = "Tesla",
                Model = "Cyber Truck",
                EngineNoise = "...",
                HonkNoise = "brmmp",
                IsDrivable = false
            };
            //add stevesCar to the carlot
            lot.Cars.Add(stevesCar);

            //Instantiation 3 "Using the constructor to allow paramater values to be placed inside properties"
            var brettsCar = new Car(2013, "Honda", "Civic", "vrrrooom", "vruuuga", true);

            //add brettsCar to the carlot
            lot.Cars.Add(brettsCar);

            //Call methods
            ryansCar.MakeEngineNoise();
            stevesCar.MakeEngineNoise();
            brettsCar.MakeEngineNoise();

            //*************BONUS*************//

            // DONE - Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //DONE - Create a CarLot class
            //DONE - It should have at least one property: a List of cars
            //DONE - Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //DONE - At the end iterate through the list printing each of car's Year, Make, and Model to the console

            foreach(var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }
        }
    }
}
