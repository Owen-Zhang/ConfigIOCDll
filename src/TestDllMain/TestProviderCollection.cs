using System;
using System.Configuration.Provider;

namespace TestDllMain
{
    public class TestProviderCollection : ProviderCollection
    {
        public new IPortal this[string name]
        {
            get { return (IPortal)base[name]; }
        }

        /// <summary>
        /// Add a provider to the collection.
        /// </summary>s
        public override void Add(ProviderBase provider)
        {
            if (provider == null)
                throw new ArgumentNullException("provider");

            if (!(provider is IPortal))
                throw new ArgumentException
                    ("Invalid provider type", "provider");

            base.Add(provider);
        }
    }
}
