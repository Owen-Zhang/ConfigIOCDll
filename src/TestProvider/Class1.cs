using System;
using TestDllMain;

namespace TestProvider
{
    public class Class1 : IPortal
    {
        public void ConsoleLine(string name)
        {
            Console.WriteLine(name);
        }
    }
}