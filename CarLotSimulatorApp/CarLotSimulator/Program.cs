using System;

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

            Car CarOne = new Car();
            //Car CarTwo = new Car();
            //Car CarThree = new Car();

            CarLot CarList = new CarLot();
            Console.WriteLine("CAR ONE");
            Console.WriteLine("--------");

            CarOne.Year = 2000;
            CarOne.Make = "Toyota";
            CarOne.Model = "Cambry";
            CarOne.EngineNoise = "low";
            CarOne.HornNoise = "loud";
            CarOne.IsDrivable = true;
            CarOne.MakeHornNoise("low");
            CarOne.MakeEngineNoise(CarOne.EngineNoise);

            Console.WriteLine("CAR TWO");
            Console.WriteLine("--------");

            Car CarTwo = new Car() { Year = 2003, Make = "Ford", Model = "Ranger", EngineNoise = "loud", HornNoise = "loud", IsDrivable = false };
            CarTwo.MakeEngineNoise("loud");
            CarTwo.MakeHornNoise("loud");


            Console.WriteLine("CAR Three");
            Console.WriteLine("--------");

            Car CarThree = new Car(2010, "Honda", "Accord", "low", "loud");

           

            CarList.vehicles.Add(CarOne);
            CarList.vehicles.Add(CarTwo);
            CarList.vehicles.Add(CarThree);

            Console.WriteLine($"The number of cars in the lot is {CarLot.NumberOfCars}");
            foreach (var vehicle in CarList.vehicles)
            {
                Console.WriteLine($"The car is {vehicle.Year } { vehicle.Make} { vehicle.Model}  engine noise - {vehicle.EngineNoise}   horn noise - {vehicle.HornNoise}   IsDrivable - {vehicle.IsDrivable}");
            } 


            //Console.WriteLine($"the car year is {CarOne.Year} ");
            
            //Console.WriteLine($"Car properties are {CarList.vehicles[0].Make}");

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
