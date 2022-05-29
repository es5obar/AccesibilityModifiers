using AccesibilityModifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicAccessibilityModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dog dog = new Dog();
            Car car = new Car()
            {
                id1_public = 1,
                Id1_public = 1
            };
            car.DriveTheCar();
        }
    }
}
