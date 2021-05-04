using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdvanced.Homework02Bonus.Interfaces
{
    public interface IGuest
    {
        int Id { get; set; }
        void ReadComment(string comment);
    }
}
