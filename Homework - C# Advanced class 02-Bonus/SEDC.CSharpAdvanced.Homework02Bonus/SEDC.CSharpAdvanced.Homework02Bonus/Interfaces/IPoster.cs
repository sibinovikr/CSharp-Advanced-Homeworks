using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdvanced.Homework02Bonus.Interfaces
{
    public interface IPoster
    {
        int Points { get; set; }
        bool IsPosterOfTheWeek { get; set; }
        void CheckStats();
    }
}
