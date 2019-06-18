﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FundingMock.Web.Enums
{
    /// <summary>
    /// Valid list of organisation group types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OrganisationType
    {
        /// <summary>
        /// Local Authority (e.g. Warwickshire).
        /// </summary>
        LocalAuthority,

        /// <summary>
        /// Academy Trust (e.g. Star Foundation).
        /// </summary>
        AcademyTrust,

        /// <summary>
        /// Regional Schools Commissioner Region (e.g. Lancashire and West Yorkshire).
        /// </summary>
        RSCRegion,

        /// <summary>
        /// Government Office Region, (e.g. North West).
        /// </summary>
        GovernmentOfficeRegion,

        /// <summary>
        /// District (e.g. Hyndburn).
        /// </summary>
        District,

        /// <summary>
        /// Ward (e.g. Milnshaw).
        /// </summary>
        Ward,

        /// <summary>
        /// Census Ward.
        /// </summary>
        CensusWard,

        /// <summary>
        /// Middle Super Output Area (e.g. Mansfield 002).
        /// </summary>
        MiddleSuperOutputArea,

        /// <summary>
        /// Lower Super Output Area (e.g. Mansfield 002A).
        /// </summary>
        LowerSuperOutputArea,

        /// <summary>
        /// Parlimentry constituency (e.g. Mansfield).
        /// </summary>
        ParliamentaryConstituency,

        /// <summary>
        /// Provider
        /// </summary>
        Provider,
    }
}