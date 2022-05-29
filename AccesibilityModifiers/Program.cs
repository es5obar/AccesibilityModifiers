using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesibilityModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            // customer.  // alan , özellik ve methodlar private olduğundan ulaşılamaz.
            GoodCustomer goodCustomer = new GoodCustomer();
            // goodCustomer . // alan , özellik ve methodlar base class ' ta private olduğundan ulaşılamaz. 
            Person person = new Person();
            // person . // alan , özellik ve methodlar private veya protected olduğundan ulaşılamaz.
            Animal animal = new Animal();
            animal.Id1_internal = 1;
            animal.id1_internal = 1;
            animal.SetAnimal();
            Vehicle vehicle = new Vehicle();
            vehicle.id1_public = 1;
            vehicle.Id1_public = 1;
            vehicle.Drive();

        }
    }

    #region Private Accessibility Modifier

    class Customer
    {
        int id1_private;
        private int id2_private;

        private int Id4_private { get; set; }

        void Shop()  // private
        {
            id1_private = 1;
            id2_private = 2;
            Id4_private = 4;
            int id3_local;
            id3_local = 3;
        }

        private void Pay()
        {
            id1_private = 1;
            id2_private = 2;
            Id4_private = 4;
            // id3_local = 3; // kullanılamaz
        }
    }
    class GoodCustomer : Customer 
    {

    }
    #endregion

    #region Protected Accessibility Modifier
    class Person
    {
        protected int id1_protected;

        protected int Id1_protected { get; set; }

        private int id2_private;

        private void Work()
        {
            id1_protected = 1;
            Id1_protected = 1;
            id2_private = 2;
        }

        protected void PersonWork()
        {
            Work();
        }
    }

    class GoodPerson : Person
    {
        void Work()
        {
            id1_protected = 1;
            Id1_protected = 1;
            // id2_private = 2;
            PersonWork();
        }
    }
    #endregion

    #region Internal Accessibility Modifier

    internal class Animal  // yazılmazsa default 'u internal
    {
        internal int id1_internal;

        internal int Id1_internal { get; set; }

        internal void SetAnimal()
        {
            id1_internal = 1;
            Id1_internal = 1;
        }
    }

    class Dog : Animal
    {
        void SetTheDog()
        {
            id1_internal = 1;
            Id1_internal = 1;
            SetAnimal();
        }
    }
    #endregion

    #region Public Accessibility Modifier

    public class Vehicle
    {
        public int id1_public;

        public int Id1_public { get; set; }

        public void Drive()
        {
            id1_public = 1;
            Id1_public = 1;
        }
    }

    public class Car : Vehicle
    {
        public void DriveTheCar ()
        {
            id1_public = 1;
            Id1_public = 1;
            Drive();
        }
    }
    #endregion
}
