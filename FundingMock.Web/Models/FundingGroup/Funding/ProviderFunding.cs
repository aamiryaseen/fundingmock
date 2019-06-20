﻿namespace FundingMock.Web.Models
{
    /// <summary>
    /// A funding item.
    /// </summary>
    public class ProviderFunding
    {
        /// <summary>
        /// A unique id for this funding. In format 'schema:v{schemaVersion}/{stream.Code}/template:v{templateVersion}/{groupingOrg.Name}/{period.Code}/funding:v{fundingVersion}/{organisation.Name}'.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The organisation for which the funding is for.
        /// </summary>
        public Organisation Organisation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Variations Variations { get; set; }

        /// <summary>
        /// The funding stream the funding relates to.
        /// </summary>
        public string FundingStreamCode { get; set; }

        /// <summary>
        /// The funding period the funding relates to.
        /// </summary>
        public string FundingPeriodCode { get; set; }

        /// <summary>
        /// Funding value.
        /// </summary>
        public FundingValue FundingValue { get; set; }

    }
}