using SEDC.CSharpAdvanced.Homework02Bonus.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdvanced.Homework02Bonus.Interfaces
{
    public interface IUser
    {
        string Username { get; set; }
        Role Role { get; set; }
        List<string> Comments { get; set; }


        void PostComment(string comment);
        void PrintUser();

    }
}
