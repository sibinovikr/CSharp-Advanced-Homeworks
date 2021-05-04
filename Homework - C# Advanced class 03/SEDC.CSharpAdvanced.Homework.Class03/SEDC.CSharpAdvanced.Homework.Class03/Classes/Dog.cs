﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdvanced.Homework.Class03.Classes
{
    public class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        public Dog()
        {
        }

        public Dog(int id, string name, string color)
        {
            Id = id;
            Name = name;
            Color = color;
        }

        public void Bark()
        {
            Console.WriteLine("Bark bark");
        }

        
    }

}
