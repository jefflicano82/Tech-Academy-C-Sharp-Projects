﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructorAssignment
{
    class Man
    {
        private int id;
        private string name;
        public Man() : this(0, "")
        {
        }

        public Man(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public Man(int id) : this(id, "")
        {
        }

        public Man(string name) : this(0, name)
        {
        }
    }
}

