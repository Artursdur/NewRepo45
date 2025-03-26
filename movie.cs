﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Movie : Media
    {
        public int Duration { get; set; } 
        public string Director { get; set; }

        public Movie(string title, string author, int yearPublished, int duration, string director)
            : base(title, author, yearPublished)
        {
            Duration = duration;
            Director = director;
        }
    }
}
