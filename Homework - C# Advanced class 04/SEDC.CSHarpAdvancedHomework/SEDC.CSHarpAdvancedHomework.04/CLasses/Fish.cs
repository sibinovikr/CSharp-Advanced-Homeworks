using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSHarpAdvancedHomework._04.CLasses
{
    public class Fish : Pet
    {
        public string Color { get; set; }
        public string Size { get; set; }
        public Fish(string name, string type, int age, string color, string size) : base(name, type, age)
        {
            Name = name;
            Type = type;
            Age = age;            
            Color = color;
            Size = size;
        }
        public override string PrintInfo()
        {
            return $"Name:{Name}, Age: {Age}, Color: {Color}, Size: {Size} Type: {Type}";
        }
    }
}
