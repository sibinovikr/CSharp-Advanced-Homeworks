using SEDC.CSharpAdvanced.Homework02Bonus.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdvanced.Homework02Bonus.Classes
{
    public abstract class User : IUser
    {
        public string Username { get; set; }
        public List<string> Comments { get; set; }
        public Role Role { get; set; }

        public User(string username, Role role)
        {
            Username = username;
            Comments = new List<string>();
            Role = role;
        }

        public void PostComment(string inputComment)
        {
            Comments.Add(inputComment);
        }
        public abstract void PrintUser();
    }
}
