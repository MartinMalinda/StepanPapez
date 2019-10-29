﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETApp.Models
{
    public class Greeting
    {
        public long Id { get; set; }
        public string Content { get; set; }
        public static long CallCount { get; set; } = 0;

        public Greeting()
        {
            Id = 1;
            Content = "Hello World!";
        }

        //public Greeting(string name)
        //{
        //    Id = CallCount;
        //    Content = name;
        //}

        public Greeting(long id, string content)
        {
            Id = id;
            Content = content;
        }
    }
}
