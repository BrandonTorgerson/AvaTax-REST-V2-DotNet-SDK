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
    /// Cost Center Request Model
    /// </summary>
    public class CostCenterRequestModel
    {
        /// <summary>
        /// The Entity Use Code
        /// </summary>
        public String entityUseCode { get; set; }

        /// <summary>
        /// Effective from Date
        /// </summary>
        public DateTime? effectiveDate { get; set; }

        /// <summary>
        /// End Date
        /// </summary>
        public DateTime? endDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Int64TaxProfileObjectReferenceModel defaultItem { get; set; }

        /// <summary>
        /// The Cost center Name
        /// </summary>
        public String costCenterCode { get; set; }


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
