﻿using System;
using TestDllMain;
using System.Configuration.Provider;

namespace TestProvider
{
    public class Class1 : ProviderBase, IPortal 
    {
        public void ConsoleLine(string name)
        {
            Console.WriteLine(string.Format("TestProvider: {0}",name));
        }
    }
}