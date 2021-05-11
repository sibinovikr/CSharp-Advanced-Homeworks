using SEDC.CSHarpAdvancedHomework._04.CLasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.CSHarpAdvancedHomework._04.Generic
{
    public class PetStore<T>
        where T : Pet
    {
        public List<T> Pets { get; set; }
        public PetStore()
        {
            Pets = new List<T>();
        }

        public void PrintPets(List<T> aPet)

        {
            if (aPet != null)
            {
                foreach (T item in aPet)
                {
                    Console.WriteLine($"Name: {item.Name} Type: {item.Type}");
                }
            }
            else
            {
                Console.WriteLine("Something wrong");
            }

        }
        public string BuyPet(string name)
        {
            T item = Pets.FirstOrDefault(pet => pet.Name.Equals(name));
            if (item != null)
            {
                Pets.Remove(item);
                return $"You bought pet with Name: {item.Name} " +
                    $"Age: {item.Age} Type: {item.Type} ";
            }
            return "There is no pet with that name in the store";
        }
    }
}
