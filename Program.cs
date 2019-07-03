using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Homework
{
    class Program
    {
        static void Main(string[] args)
        {

            Car myCar = new Car("CaMakers", "Car Model", 2001, "A Good Engine", 0, 0, 10000, 100, "White");

            CarPreviewer carPreviewer = new CarPreviewer(myCar);

            carPreviewer.ViewCar();
        }
    }
}
