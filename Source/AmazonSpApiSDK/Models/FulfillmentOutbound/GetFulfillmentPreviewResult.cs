/* 
 * Selling Partner API for Fulfillment Outbound
 *
 * The Selling Partner API for Fulfillment Outbound lets you create applications that help a seller fulfill Multi-Channel Fulfillment orders using their inventory in Amazon's fulfillment network. You can get information on both potential and existing fulfillment orders.
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

namespace AmazonSpApiSDK.Models.FulfillmentOutbound
{
    /// <summary>
    /// A list of fulfillment order previews, including estimated shipping weights, estimated shipping fees, and estimated ship dates and arrival dates.
    /// </summary>
    [DataContract]
    public partial class GetFulfillmentPreviewResult : IEquatable<GetFulfillmentPreviewResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetFulfillmentPreviewResult" /> class.
        /// </summary>
        /// <param name="FulfillmentPreviews">FulfillmentPreviews.</param>
        public GetFulfillmentPreviewResult(FulfillmentPreviewList FulfillmentPreviews = default(FulfillmentPreviewList))
        {
            this.FulfillmentPreviews = FulfillmentPreviews;
        }

        /// <summary>
        /// Gets or Sets FulfillmentPreviews
        /// </summary>
        [DataMember(Name = "FulfillmentPreviews", EmitDefaultValue = false)]
        public FulfillmentPreviewList FulfillmentPreviews { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetFulfillmentPreviewResult {\n");
            sb.Append("  FulfillmentPreviews: ").Append(FulfillmentPreviews).Append("\n");
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
            return this.Equals(input as GetFulfillmentPreviewResult);
        }

        /// <summary>
        /// Returns true if GetFulfillmentPreviewResult instances are equal
        /// </summary>
        /// <param name="input">Instance of GetFulfillmentPreviewResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetFulfillmentPreviewResult input)
        {
            if (input == null)
                return false;

            return
                (
                    this.FulfillmentPreviews == input.FulfillmentPreviews ||
                    (this.FulfillmentPreviews != null &&
                    this.FulfillmentPreviews.Equals(input.FulfillmentPreviews))
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
                if (this.FulfillmentPreviews != null)
                    hashCode = hashCode * 59 + this.FulfillmentPreviews.GetHashCode();
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
