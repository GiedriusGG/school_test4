using System;

namespace school_test4
{
    class Program
    {
        interface IVehicle
        {
            void Drive();
            void Park();
        }

        class BmwCar : IVehicle
        {
            public void Drive()
            {
                Console.WriteLine("Driving into the bus stop");
            }
            public void Park()
            {
                Console.WriteLine("Parking on as many parking spots as possible at the same time");
            }
        }

        class AnyOtherCar : IVehicle
        {
            public void Drive()
            {
                Console.WriteLine("Driving to the destination");
            }
            public void Park()
            {
                Console.WriteLine("Parking on a single parking spot");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Task 4: Create an interface IVehicle with methods Drive() and Park(). Create two classes implementing this interface. BmwCar and AnyOtherCar. BmwCar Drive method prints: “Driving into the bus stop” AnyOtherCar Drive method prints: “Driving to the destination” BmwCar Park method prints: “Parking on as many parking spots as possible at the same time” AnyOtherCar Park method prints: “Parking on a single parking spot” Create objects of both cars and invoke Drive and Park methods on BmwCar object and then do the same with AnyOtherCar. (DISCLAIMER: this one is just a joke and doesn‘t imply that you are a bad driver in case you drive BMW)");
            Console.WriteLine("Output:");
            IVehicle car = new BmwCar();            
            car.Drive();
            car.Park();
            car = new AnyOtherCar();
            car.Drive();
            car.Park();
            
        }
    }
}
