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
using System.Collections.Generic;
using System.Configuration;

namespace TestDllMain
{
    public static class StaticFile
    {
        public static void ConsoleLine(string name, string providerName = null)
        {
            var portaler = ProviderManager.GetPortal(providerName);
            if (portaler == null)
                throw new ArgumentException(string.Format("XXX Config has wrong,  '{0}' desn't find ", providerName));

            portaler.ConsoleLine(name);
        }
    }
}
