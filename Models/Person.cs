﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoAPI.Models
{
    public class Person
    {
        public int Id { get; set; } = 0;
        public string FirstName { get; set; } = "";
        public string Lastname { get; set; } = "";
        public int Age { get; set; }
    }
}