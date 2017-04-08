// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Country.cs" company="Newegg" Author="oz3t">
//   Copyright (c) 2017 Newegg.inc. All rights reserved.
// </copyright>
// <summary>
//   Country created at  3/31/2017 2:52:53 PM
// </summary>
//<Description>
//
//</Description>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace Test
{
    public class Country
    {
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public string CountryCharCode { get; set; }
        public string ContientName { get; set; }
        public string FlagImageCode { get; set; }
    }

    public class CountryComparer : IEqualityComparer<Country>
    {
        public bool Equals(Country x, Country y)
        {
            if (Object.ReferenceEquals(x, y)) return true;

            if (Object.ReferenceEquals(x, null) || Object.ReferenceEquals(y, null))
                return false;

            return string.Equals(x.CountryCharCode, y.CountryCharCode, StringComparison.OrdinalIgnoreCase);
        }

        public int GetHashCode(Country country)
        {
            if (Object.ReferenceEquals(country, null)) return 0;

            int hashcountryCode = country.CountryCharCode.GetHashCode();

            return hashcountryCode;
        }
    }
}
