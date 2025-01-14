/* 
 * Selling Partner API for Fulfillment Inbound
 *
 * The Selling Partner API for Fulfillment Inbound lets you create applications that create and update inbound shipments of inventory to Amazon's fulfillment network.
 *
 * OpenAPI spec version: v0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace AmazonSpApiSDK.Models.FulfillmentInbound
{
    /// <summary>
    /// GetInboundGuidanceResult
    /// </summary>
    [DataContract]
    public partial class GetInboundGuidanceResult : IEquatable<GetInboundGuidanceResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetInboundGuidanceResult" /> class.
        /// </summary>
        /// <param name="SKUInboundGuidanceList">SKUInboundGuidanceList.</param>
        /// <param name="InvalidSKUList">InvalidSKUList.</param>
        /// <param name="ASINInboundGuidanceList">ASINInboundGuidanceList.</param>
        /// <param name="InvalidASINList">InvalidASINList.</param>
        public GetInboundGuidanceResult(SKUInboundGuidanceList SKUInboundGuidanceList = default(SKUInboundGuidanceList), InvalidSKUList InvalidSKUList = default(InvalidSKUList), ASINInboundGuidanceList ASINInboundGuidanceList = default(ASINInboundGuidanceList), InvalidASINList InvalidASINList = default(InvalidASINList))
        {
            this.SKUInboundGuidanceList = SKUInboundGuidanceList;
            this.InvalidSKUList = InvalidSKUList;
            this.ASINInboundGuidanceList = ASINInboundGuidanceList;
            this.InvalidASINList = InvalidASINList;
        }

        /// <summary>
        /// Gets or Sets SKUInboundGuidanceList
        /// </summary>
        [DataMember(Name = "SKUInboundGuidanceList", EmitDefaultValue = false)]
        public SKUInboundGuidanceList SKUInboundGuidanceList { get; set; }

        /// <summary>
        /// Gets or Sets InvalidSKUList
        /// </summary>
        [DataMember(Name = "InvalidSKUList", EmitDefaultValue = false)]
        public InvalidSKUList InvalidSKUList { get; set; }

        /// <summary>
        /// Gets or Sets ASINInboundGuidanceList
        /// </summary>
        [DataMember(Name = "ASINInboundGuidanceList", EmitDefaultValue = false)]
        public ASINInboundGuidanceList ASINInboundGuidanceList { get; set; }

        /// <summary>
        /// Gets or Sets InvalidASINList
        /// </summary>
        [DataMember(Name = "InvalidASINList", EmitDefaultValue = false)]
        public InvalidASINList InvalidASINList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetInboundGuidanceResult {\n");
            sb.Append("  SKUInboundGuidanceList: ").Append(SKUInboundGuidanceList).Append("\n");
            sb.Append("  InvalidSKUList: ").Append(InvalidSKUList).Append("\n");
            sb.Append("  ASINInboundGuidanceList: ").Append(ASINInboundGuidanceList).Append("\n");
            sb.Append("  InvalidASINList: ").Append(InvalidASINList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetInboundGuidanceResult);
        }

        /// <summary>
        /// Returns true if GetInboundGuidanceResult instances are equal
        /// </summary>
        /// <param name="input">Instance of GetInboundGuidanceResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetInboundGuidanceResult input)
        {
            if (input == null)
                return false;

            return
                (
                    this.SKUInboundGuidanceList == input.SKUInboundGuidanceList ||
                    (this.SKUInboundGuidanceList != null &&
                    this.SKUInboundGuidanceList.Equals(input.SKUInboundGuidanceList))
                ) &&
                (
                    this.InvalidSKUList == input.InvalidSKUList ||
                    (this.InvalidSKUList != null &&
                    this.InvalidSKUList.Equals(input.InvalidSKUList))
                ) &&
                (
                    this.ASINInboundGuidanceList == input.ASINInboundGuidanceList ||
                    (this.ASINInboundGuidanceList != null &&
                    this.ASINInboundGuidanceList.Equals(input.ASINInboundGuidanceList))
                ) &&
                (
                    this.InvalidASINList == input.InvalidASINList ||
                    (this.InvalidASINList != null &&
                    this.InvalidASINList.Equals(input.InvalidASINList))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.SKUInboundGuidanceList != null)
                    hashCode = hashCode * 59 + this.SKUInboundGuidanceList.GetHashCode();
                if (this.InvalidSKUList != null)
                    hashCode = hashCode * 59 + this.InvalidSKUList.GetHashCode();
                if (this.ASINInboundGuidanceList != null)
                    hashCode = hashCode * 59 + this.ASINInboundGuidanceList.GetHashCode();
                if (this.InvalidASINList != null)
                    hashCode = hashCode * 59 + this.InvalidASINList.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
