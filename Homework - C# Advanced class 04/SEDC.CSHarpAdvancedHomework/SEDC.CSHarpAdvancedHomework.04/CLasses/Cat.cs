using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSHarpAdvancedHomework._04.CLasses
{
    public class Cat : Pet
    {
        public int LivesLeft { get; set; }

        public Cat(string name, string type, int age, int livesLeft) : base(name, type, age)
        {
            Name = name;
            Type = type;
            Age = age;            
            LivesLeft = livesLeft;
        }
        public string Lazy()
        {
            return $"The {Type}, {Name} is lazy.";
        }

        public override string PrintInfo()
        {
            return $"Name:{Name}, Age: {Age}, Lives left: {LivesLeft} AnimalType: {Type}";
        }
    }
}
