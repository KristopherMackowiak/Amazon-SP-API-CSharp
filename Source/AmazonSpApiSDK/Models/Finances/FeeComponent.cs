/* 
 * Selling Partner API for Finances
 *
 * The Selling Partner API for Finances helps you obtain financial information relevant to a seller's business. You can obtain financial events for a given order, financial event group, or date range without having to wait until a statement period closes. You can also obtain financial event groups for a given date range.
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

namespace AmazonSpApiSDK.Models.Finances
{
    /// <summary>
    /// A fee associated with the event.
    /// </summary>
    [DataContract]
    public partial class FeeComponent : IEquatable<FeeComponent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeeComponent" /> class.
        /// </summary>
        /// <param name="FeeType">The type of fee. For more information about Selling on Amazon fees, see [Selling on Amazon Fee Schedule](https://sellercentral.amazon.com/gp/help/200336920) on Seller Central. For more information about Fulfillment by Amazon fees, see [FBA features, services and fees](https://sellercentral.amazon.com/gp/help/201074400) on Seller Central..</param>
        /// <param name="FeeAmount">The amount of the fee..</param>
        public FeeComponent(string FeeType = default(string), Currency FeeAmount = default(Currency))
        {
            this.FeeType = FeeType;
            this.FeeAmount = FeeAmount;
        }

        /// <summary>
        /// The type of fee. For more information about Selling on Amazon fees, see [Selling on Amazon Fee Schedule](https://sellercentral.amazon.com/gp/help/200336920) on Seller Central. For more information about Fulfillment by Amazon fees, see [FBA features, services and fees](https://sellercentral.amazon.com/gp/help/201074400) on Seller Central.
        /// </summary>
        /// <value>The type of fee. For more information about Selling on Amazon fees, see [Selling on Amazon Fee Schedule](https://sellercentral.amazon.com/gp/help/200336920) on Seller Central. For more information about Fulfillment by Amazon fees, see [FBA features, services and fees](https://sellercentral.amazon.com/gp/help/201074400) on Seller Central.</value>
        [DataMember(Name = "FeeType", EmitDefaultValue = false)]
        public string FeeType { get; set; }

        /// <summary>
        /// The amount of the fee.
        /// </summary>
        /// <value>The amount of the fee.</value>
        [DataMember(Name = "FeeAmount", EmitDefaultValue = false)]
        public Currency FeeAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FeeComponent {\n");
            sb.Append("  FeeType: ").Append(FeeType).Append("\n");
            sb.Append("  FeeAmount: ").Append(FeeAmount).Append("\n");
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
            return this.Equals(input as FeeComponent);
        }

        /// <summary>
        /// Returns true if FeeComponent instances are equal
        /// </summary>
        /// <param name="input">Instance of FeeComponent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeeComponent input)
        {
            if (input == null)
                return false;

            return
                (
                    this.FeeType == input.FeeType ||
                    (this.FeeType != null &&
                    this.FeeType.Equals(input.FeeType))
                ) &&
                (
                    this.FeeAmount == input.FeeAmount ||
                    (this.FeeAmount != null &&
                    this.FeeAmount.Equals(input.FeeAmount))
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
                if (this.FeeType != null)
                    hashCode = hashCode * 59 + this.FeeType.GetHashCode();
                if (this.FeeAmount != null)
                    hashCode = hashCode * 59 + this.FeeAmount.GetHashCode();
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
