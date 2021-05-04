using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.CSharpAdvanced.Homework.Class02.Interfaces
{
    public interface ITeacher
    {
        public string Subject { get; set; }

        void PrintUser();
    }
}
