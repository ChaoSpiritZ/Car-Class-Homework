using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Homework
{
    class Car
    {

        private string _manufacturer;
        private string _model;
        private int _manufactureYear;
        private string _engineType;
        private int _currentKilometrage;
        private int _lastMaintenance;
        private int _maintenanceGrace;
        private int _engineVolume;
        private string _color;
        private bool _isOn;
        private string _currentLocation;

        public Car(string manufacturer, string model, int manufactureYear, string engineType, int currentKilometrage, int lastMaintenance, int maintenanceGrace, int engineVolume, string color)
        {
            _manufacturer = manufacturer;
            _model = model;
            _manufactureYear = manufactureYear;
            _engineType = engineType;
            _currentKilometrage = currentKilometrage;
            _lastMaintenance = lastMaintenance;
            _maintenanceGrace = maintenanceGrace;
            _engineVolume = engineVolume;
            _color = color;
            _isOn = false;
            _currentLocation = "Home";
        }

        public string GetManufacturer()
        {
            return _manufacturer;
        }

        public string GetModel()
        {
            return _model;
        }

        public int GetManufactureYear()
        {
            return _manufactureYear;
        }

        public string GetEngineType()
        {
            return _engineType;
        }

        public int GetCurrentKilometrage()
        {
            return _currentKilometrage;
        }

        public int GetLastMaintenance()
        {
            return _lastMaintenance;
        }

        public int GetMaintenanceGrace()
        {
            return _maintenanceGrace;
        }

        public int GetEngineVolume()
        {
            return _engineVolume;
        }

        public string GetColor()
        {
            return _color;
        }

        public bool GetIsOn()
        {
            return _isOn;
        }

        public string GetCurrentLocation()
        {
            return _currentLocation;
        }

        public bool NeedMaintenance()
        {
            if(_currentKilometrage >= _lastMaintenance + _maintenanceGrace)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SetLastMaintenance()
        {
            Console.WriteLine("---------------------------------------");
            if (_isOn == false)
            {
                Console.WriteLine("the car is not turned on");
            }
            else
            {
                _currentKilometrage += 10;
                _lastMaintenance = _currentKilometrage;
                Console.WriteLine("The car works fine!");
            }
        }

        public void TurnOnCar()
        {
            if(_isOn == true)
            {
                Console.WriteLine("The car is already on");
            }
            _isOn = true;
        }

        public void TurnOffCar()
        {
            if (_isOn == false)
            {
                Console.WriteLine("The car is already off");
            }
            _isOn = false;
        }

        public void DriveTo(string location, int locationDistance)
        {
            Console.WriteLine("---------------------------------------");
            if(_isOn == false)
            {
                Console.WriteLine("the car is not turned on");
            }
            else if(locationDistance > _maintenanceGrace)
            {
                Console.WriteLine("You can't drive THAT far");
            }
            else if(_currentKilometrage - _lastMaintenance + locationDistance > _maintenanceGrace)
            {
                Console.WriteLine("The car needs maintenance before driving that far");
            }
            else
            {
                _currentLocation = location;
                _currentKilometrage += locationDistance;
                Console.WriteLine("You have reached: " + _currentLocation);
            }
        }
    }
}
