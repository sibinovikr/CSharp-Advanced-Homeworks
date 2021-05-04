using SEDC.CSharpAdvanced.Homework02Bonus.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdvanced.Homework02Bonus.Interfaces
{
    public interface IModerator
    {
        public List<User> Users { get; set; }
        void BanUser(User user, string reason);
    }
}
