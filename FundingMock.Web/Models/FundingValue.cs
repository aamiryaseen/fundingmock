﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace FundingMock.Web.Models
{
    /// <summary>
    /// The total amount paid, and the periods/envelopes that it was composed of.
    /// </summary>
    public class FundingValue
    {
        /// <summary>
        /// The funding value amount in pence. Rolled up from all child Funding Lines where Type = Payment
        /// </summary>
        [JsonProperty("totalValue")]
        public decimal TotalValue { get; set; }

        /// <summary>
        /// The lines that make up this funding. 
        /// </summary>
        [JsonProperty("fundingLines")]
        public IEnumerable<FundingLine> FundingLines { get; set; }
    }
}