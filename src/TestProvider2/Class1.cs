using System;
using TestDllMain;
using System.Configuration.Provider;

namespace TestProvider2
{
    public class Class1 : ProviderBase, IPortal
    {
        public void ConsoleLine(string name)
        {
            Console.WriteLine(string.Format("TestProvider2: {0}", name));
        }
    }
}
