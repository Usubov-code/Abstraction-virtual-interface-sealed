using System;

namespace Abstraction__virtual__interface__sealed
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //DeathStar dead1 = new DeathStar();


            //dead1.FireLaser();
            #endregion

            #region Task2
            //Car car1 = new Car();
            //car1.Drive();
            #endregion
            #region Task3 
            Console.WriteLine("Please enter the dog name");
            Dog dog1 = new Dog();
            dog1.Name = Console.ReadLine();

            dog1.Eat();




            #endregion


        }

    }
}
