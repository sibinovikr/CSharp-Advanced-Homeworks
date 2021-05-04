using SEDC.CSharpAdvanced.Homework.Class03.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdvanced.Homework.Class03.StaticClasses
{
    public static class DogShelter
    {
        public static List<Dog> Dogs { get; set; }

        static DogShelter()
        {
            Dogs = new List<Dog>();
        }

        public static void PrintAll()
        {
            foreach (Dog dog in Dogs)
            {
                Console.WriteLine($"Id: {dog.Id} Name: {dog.Name} Color: {dog.Color}");
            }
        }

        public static void AddDog(Dog dog)
        {
            Dogs.Add(dog);
            Console.WriteLine($"The dog {dog.Name} is added to list.");
        }
    }
}
