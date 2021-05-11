using SEDC.CSHarpAdvancedHomework._04.CLasses;
using System;
using SEDC.CSHarpAdvancedHomework._04.Generic;

namespace SEDC.CSHarpAdvancedHomework._04
{
    class Program
    {
        public static PetStore<Dog> DogStore = new PetStore<Dog>();
        public static PetStore<Cat> CatStore = new PetStore<Cat>();
        public static PetStore<Fish> FishStore = new PetStore<Fish>();


        static void Main(string[] args)
        {
            DogStore.Pets.Add(new Dog("Bella", "Dog", 7, "Bacon"));
            DogStore.Pets.Add(new Dog("Charlie", "Dog", 7, "Chicken"));
            DogStore.Pets.Add(new Dog("Luna", "Dog", 7, "Steak"));

            CatStore.Pets.Add(new Cat("Lily", "Cat", 2, 7));
            CatStore.Pets.Add(new Cat("Gracie", "Cat", 7, 10));
            CatStore.Pets.Add(new Cat("Molly", "Cat", 5, 9));

            FishStore.Pets.Add(new Fish("Blue", "Fish", 1, "Blue", "small"));
            FishStore.Pets.Add(new Fish("Moby", "Fish", 2, "Red-White", "medium"));
            FishStore.Pets.Add(new Fish("Nemo", "Fish", 3, "Orange-black", "big"));


            Console.WriteLine("Printing all pets..");

            DogStore.PrintPets(DogStore.Pets);
            CatStore.PrintPets(CatStore.Pets);
            FishStore.PrintPets(FishStore.Pets);

            Console.WriteLine("----------------------------------");

            Console.WriteLine("Type the name of the dog you want to buy");
            Console.WriteLine(DogStore.BuyPet(Console.ReadLine()));
            Console.WriteLine("Type the name of the cat you want to buy");
            Console.WriteLine(CatStore.BuyPet(Console.ReadLine()));
            Console.WriteLine("Type the name of the fish you want to buy");
            Console.WriteLine(FishStore.BuyPet(Console.ReadLine()));
            

            Console.ReadLine();
        }
    }
}
