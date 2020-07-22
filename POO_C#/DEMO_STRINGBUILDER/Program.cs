﻿using System;
using DEMO_STRINGBUILDER.Entities;

namespace DEMO_STRINGBUILDER
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip");

            Comment c2 = new Comment("Wow that's awesome!");

            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zealand",
                "I'am going to visite this wonderful country!",
                12);
          
            p1.addComment(c1);
            p1.addComment(c2);

            

            Comment c3 = new Comment("Good night");
            
            Comment c4 = new Comment("May the Force be with you");

            Post p2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good night guys",
                "See you tomorrow",
                5);

                p2.addComment(c3);
                p2.addComment(c4);


                System.Console.WriteLine(p1);
                System.Console.WriteLine(p2);
        }
    }
}
