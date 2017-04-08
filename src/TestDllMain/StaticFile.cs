// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StaticFile.cs" company="Newegg" Author="oz3t">
//   Copyright (c) 2017 Newegg.inc. All rights reserved.
// </copyright>
// <summary>
//   StaticFile created at  4/8/2017 5:19:39 PM
// </summary>
//<Description>
//
//</Description>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Configuration;

namespace TestDllMain
{
    public class StaticFile
    {
        //private readonly Dictionary<string, ILog> logs = new Dictionary<string, ILog>();
        /*
         public ILog GetLog(string key)
        {
            using (Locker.ReadRegion(this.SyncRoot))
            {
                ILog log;
                if (!this.logs.TryGetValue(key, out log))
                {
                    log = this.CreateLog(key);
                    this.logs[key] = log;
                }
                return log;
            }
        }
            
         * Cache 
         */
        public static void TestImportOtherDllFunction()
        {
            var result2 = ConfigurationManager.GetSection("TestSection") as ProviderSection;
            foreach (ProviderSettings item in result2.Providers)
            {
                var obj = (IPortal)Activator.CreateInstance(System.Type.GetType(item.Type))
            }
        }
    }
}
