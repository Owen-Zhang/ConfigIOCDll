﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDllMain;

namespace TestChild
{
    public class Class1
    {
        public void PortalConosle(string name)
        {
            StaticFile.ConsoleLine(name);

            StaticFile.ConsoleLine(name,"other");
        }
    }
}
