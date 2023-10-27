using System;
using System.Collections.Generic;
using Newtonsoft.Json;

/*
 * AvaTax API Client Library
 *
 * (c) 2004-2023 Avalara, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author Jonathan Wenger <jonathan.wenger@avalara.com>
 * @author Sachin Baijal <sachin.baijal@avalara.com>
 * Swagger name: AvaTaxClient
 */

namespace Avalara.AvaTax.RestClient
{
    /// <summary>
    /// AP Config Setting Response Model
    /// </summary>
    public class APConfigSettingSuccessResponseModel
    {
        /// <summary>
        /// The Rule Id
        /// </summary>
        public Int64? ruleId { get; set; }

        /// <summary>
        /// CompanyId to which the rule belongs
        /// </summary>
        public Int32? companyId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public TaxProfileMetaDataModel meta { get; set; }

        /// <summary>
        /// The Amount
        /// </summary>
        public Int64? amount { get; set; }

        /// <summary>
        /// The Variance For Ignore
        /// </summary>
        public Int64? varianceForIgnore { get; set; }

        /// <summary>
        /// The Variance For Accrue
        /// </summary>
        public Int64? varianceForAccrue { get; set; }

        /// <summary>
        /// The Variance Percent
        /// </summary>
        public Int64? variancePercent { get; set; }


        /// <summary>
        /// Convert this object to a JSON string of itself
        /// </summary>
        /// <returns>A JSON string of this object</returns>
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, new JsonSerializerSettings() { Formatting = Formatting.Indented });
        }
    }
}
