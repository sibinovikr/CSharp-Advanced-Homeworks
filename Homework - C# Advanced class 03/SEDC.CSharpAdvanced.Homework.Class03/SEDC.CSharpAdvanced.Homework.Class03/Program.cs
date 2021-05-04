using SEDC.CSharpAdvanced.Homework.Class03.Classes;
using SEDC.CSharpAdvanced.Homework.Class03.StaticClasses;
using System;

namespace SEDC.CSharpAdvanced.Homework.Class03
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog(1, "M", "Brown");            
            Dog dog2 = new Dog() { Name = "Leo" };            
            Dog dog3 = new Dog(3, "Sparky", "Black");

            Validate.Validated(dog1);
            Validate.Validated(dog2);
            Validate.Validated(dog3);            

            Console.WriteLine("------------------------------------");

            DogShelter.AddDog(dog1);
            DogShelter.AddDog(dog2);
            DogShelter.AddDog(dog3);

            Console.WriteLine("-----------------------------------");

            DogShelter.PrintAll();

            Console.ReadLine();
        }


       
    }
}
