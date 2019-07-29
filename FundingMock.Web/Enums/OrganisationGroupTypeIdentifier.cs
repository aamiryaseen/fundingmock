﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FundingMock.Web.Enums
{
    /// <summary>
    /// Valid list of organisation group types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OrganisationGroupTypeIdentifier
    {
        /// <summary>
        /// Local Authority (e.g. Warwickshire).
        /// </summary>
        LocalAuthorityCode,

        /// <summary>
        /// Academy Trust (e.g. Star Foundation).
        /// </summary>
        AcademyTrustCode,

        /// <summary>
        /// Regional Schools Commissioner Region (e.g. Lancashire and West Yorkshire).
        /// </summary>
        RSCRegionCode,

        /// <summary>
        /// Government Office Region, (e.g. North West).
        /// </summary>
        GovernmentOfficeRegionCode,

        /// <summary>
        /// District (e.g. Hyndburn).
        /// </summary>
        DistrictCode,

        /// <summary>
        /// Ward (e.g. Milnshaw).
        /// </summary>
        WardCode,

        /// <summary>
        /// Census Ward.
        /// </summary>
        CensusWardCode,

        /// <summary>
        /// Middle Super Output Area (e.g. Mansfield 002).
        /// </summary>
        MiddleSuperOutputAreaCode,

        /// <summary>
        /// Lower Super Output Area (e.g. Mansfield 002A).
        /// </summary>
        LowerSuperOutputAreaCode,

        /// <summary>
        /// Parlimentry constituency (e.g. Mansfield).
        /// </summary>
        ParliamentaryConstituencyCode,

        /// <summary>
        /// Region
        /// </summary>
        RegionCode,

        /// <summary>
        /// Country eg GB
        /// </summary>
        CountryCode,

        /// <summary>
        /// 
        /// </summary>
        LocalGovernmentGroupCode,
    }
}