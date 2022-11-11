﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppUI
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Mail { get; set; }

        public SexType Sex { get; set; }
    }

    public enum SexType
    {
        Male,
        Female
    }
}
