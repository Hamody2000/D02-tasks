﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskD02
{
    public class Employee
    {
        int id;
        string name;
        int age;

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name}:{Age};{Id}";
        }
    }
}
