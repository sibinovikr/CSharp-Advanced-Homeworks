using SEDC.CSharpAdvanced.Homework02Bonus.Classes;
using System;

namespace SEDC.CSharpAdvanced.Homework02Bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            Poster poster = new Poster("Eva", 500);
            Guest guest = new Guest("Anna", 430);
            Moderator moderator = new Moderator("moderator123");

            poster.PostComment("comment 01");
            poster.PostComment("comment 02");
            poster.PostComment("comment 03");
            poster.PostComment("comment 04");

            poster.PrintUser();
            poster.CheckStats();
            Console.WriteLine("------------------------------------------------------------");

            guest.PrintUser();
            guest.ReadComment("some comment...");
            Console.WriteLine("------------------------------------------------------------");

            moderator.PrintUser();
            moderator.BanUser(poster, "offensive comments");


            Console.ReadLine();
        }
    }
}