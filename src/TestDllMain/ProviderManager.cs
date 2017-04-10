using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace TestDllMain
{
    public static class ProviderManager
    {
        private static object _lockobj = new object();
        private static string defaultPortalProvider = string.Empty; 
        //private static readonly  Dictionary<string, IPortal> portals = new Dictionary<string, IPortal>();
        private static readonly TestProviderCollection providersCollection = new TestProviderCollection();

        static ProviderManager()
        {
            Init();
        }

        private static void Init()
        {
            var result2 = ConfigurationManager.GetSection("TestSection") as ProviderSection;
            defaultPortalProvider = result2.DefaultProvider;

            /* 自己实例化， 也可以用ProvidersHelper实例化
            foreach (ProviderSettings item in result2.Providers)
            {
                var type = System.Type.GetType(item.Type);
                if (type == null)
                    throw new ArgumentException("Can't find '{0}' in  bin pathfolder.");

                var obj = (IPortal)Activator.CreateInstance(type);
                if (obj != null)
                    portals[item.Name] = obj;
            }*/

            ProvidersHelper.InstantiateProviders(result2.Providers, providersCollection, typeof(IPortal));
        }

        internal static IPortal GetPortal(string providerName)
        {
            IPortal portal = null;
            /* 
            if (portals.Count == 0)
            {
                lock (_lockobj)
                {
                    Init();
                }
            }*/

            if (string.IsNullOrWhiteSpace(providerName))
                providerName = defaultPortalProvider;

            //portals.TryGetValue(providerName, out portal);
            portal = (IPortal)providersCollection[providerName];
            return portal;
        }
    }
}
