using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSHarpAdvancedHomework._04.CLasses
{
    public class Dog : Pet
    {
        public string GoodBoi { get; set; }
        public string FavoriteFood { get; set; }

        public override string PrintInfo()
        {
            return $"Name: {Name}, Age: {Age}, Favorite food: {FavoriteFood} AnimalType: {Type}";
        }

        public Dog(string name, string type, int age, string favoriteFood) : base(name, type, age)
        {
            this.Name = name;
            this.Type = type;
            this.Age = age;            
            this.FavoriteFood = favoriteFood;
        }

        public string GoodBoy()
        {
            return $"{Name} is good dog. ";
        }
    }
}
