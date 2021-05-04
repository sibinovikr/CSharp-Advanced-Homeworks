using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdvanced.Homework.Class03.Classes
{
    public static class Validate
    {
        public static void Validated(Dog dog)
        {
            if (dog.Id != 0 && dog.Name != string.Empty && dog.Color != string.Empty)
            {
                if (dog.Id >= 0 && dog.Name.Length > 2)
                {
                    Console.WriteLine("The dog has all parameters!");
                }
                else
                {
                    Console.WriteLine("The dog Id or Name is not valid!");
                }
            }
            else
            {
                Console.WriteLine("The dog miss properites!");
            }
        }
    }
}
