using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Homework
{
    class CarPreviewer
    {

        private Car _car;

        public CarPreviewer(Car car)
        {
            _car = car;
        }

        public void CarDetails()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Manufacturer: " + _car.GetManufacturer());
            Console.WriteLine("Model: " + _car.GetModel());
            Console.WriteLine("Manufacturing Year: " + _car.GetManufactureYear());
            Console.WriteLine("Engine Type: " + _car.GetEngineType());
            Console.WriteLine("Kilometrage: " + _car.GetCurrentKilometrage());
            Console.WriteLine("Last Maintenance: " + _car.GetLastMaintenance());
            Console.WriteLine("Maintenance Grace: " + _car.GetMaintenanceGrace());
            Console.WriteLine("Engine Volume: " + _car.GetEngineVolume());
            Console.WriteLine("Car Color: " + _car.GetColor());
            Console.WriteLine("Current Location: " + _car.GetCurrentLocation());
            if (_car.GetIsOn() == true)
            {
                Console.WriteLine("The Car is On");
            }
            else
            {
                Console.WriteLine("The Car is Off");
            }
            Console.WriteLine("");
        }

        public bool ShowCarMenu()
        {
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("You are currently at: " + _car.GetCurrentLocation());
            Console.WriteLine("Kilometrage: " + _car.GetCurrentKilometrage());
            Console.WriteLine("Last Maintenance: " + _car.GetLastMaintenance());

            if (_car.GetIsOn() == true)
            {
                Console.WriteLine("The Car is On");
            }
            else
            {
                Console.WriteLine("The Car is Off");
            }
            Console.WriteLine("");
            Console.WriteLine("Enter 'ON' to turn on car, 'OFF' to turn off, 'D' for details, 'Q' to exit menu, 'M' for maintenance, or enter location:");
            string cmd = Console.ReadLine();


            cmd = cmd.ToUpper();

            switch (cmd)
            {
                case "ON": _car.TurnOnCar(); break;
                case "OFF": _car.TurnOffCar(); break;
                case "D": CarDetails(); break;
                case "M": _car.SetLastMaintenance(); break;
                case "Q": return false;
                default:
                    if(cmd == _car.GetCurrentLocation().ToUpper())
                    {
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("You are already here!"); break;
                    }
                    else
                    {
                        Console.WriteLine("Enter the distance it takes to reach that location:");
                        int distance;
                        if(int.TryParse(Console.ReadLine(), out distance) == true)
                        {
                            _car.DriveTo(cmd, distance);
                        }
                        break;
                    }
            }

            return true;
        }

        public void ViewCar()
        {
            CarDetails();
            while(ShowCarMenu() == true) { }
        }
    }
}
