﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBAPILearning2.RequestModels
{
    public class Student
    {
        public int studentid  { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int ? Mobile { get; set; }
        public string City { get; set; }
        public string gender { get; set; }
        public DateTime ?DOB { get; set; }

    }
}


