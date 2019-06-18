﻿using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FundingMock.Web.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ProviderOpenReason
    {
        [EnumMember(Value = "Not applicable")]
        NotApplicable,

        [EnumMember(Value = "Result of Amalgamation")]
        ResultOfAmalgamation,

        [EnumMember(Value = "Result of Closure")]
        ResultOfClosure,

        [EnumMember(Value = "New Provision")]
        NewProvision,

        [EnumMember(Value = "Fresh Start")]
        FreshStart,

        [EnumMember(Value = "Change in status")]
        ChangeInStatus,

        [EnumMember(Value = "Not Recorded")]
        NotRecorded,

        [EnumMember(Value = "New Nursery School")]
        NewNurserySchool,

        [EnumMember(Value = "Change Religious Character")]
        ChangeReligiousCharacter,

        [EnumMember(Value = "Former Independent")]
        FormerIndependent,

        [EnumMember(Value = "Academy Free School")]
        AcademyFreeSchool,

        [EnumMember(Value = "Academy Converter")]
        AcademyConverter,

        [EnumMember(Value = "Free Special School")]
        FreeSpecialSchool,
    }
}
