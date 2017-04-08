// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProviderSection.cs" company="Newegg" Author="oz3t">
//   Copyright (c) 2017 Newegg.inc. All rights reserved.
// </copyright>
// <summary>
//   ProviderSection created at  4/8/2017 4:12:39 PM
// </summary>
//<Description>
//
//</Description>
// --------------------------------------------------------------------------------------------------------------------
using System.Configuration;

namespace TestDllMain
{
    public class ProviderSection : ConfigurationSection
    {
        [ConfigurationProperty("providers")]
        public ProviderSettingsCollection Providers
        {
            get {
                return (ProviderSettingsCollection)base["providers"];
            }
        }
    }
}
