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
    /// Information about the taxes withheld.
    /// </summary>
    [DataContract]
    public partial class TaxWithheldComponent : IEquatable<TaxWithheldComponent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxWithheldComponent" /> class.
        /// </summary>
        /// <param name="TaxCollectionModel">The tax collection model applied to the item.  Possible values:  * MarketplaceFacilitator - Tax is withheld and remitted to the taxing authority by Amazon on behalf of the seller.  * Standard - Tax is paid to the seller and not remitted to the taxing authority by Amazon..</param>
        /// <param name="TaxesWithheld">A list of charges that represent the types and amounts of taxes withheld..</param>
        public TaxWithheldComponent(string TaxCollectionModel = default(string), ChargeComponentList TaxesWithheld = default(ChargeComponentList))
        {
            this.TaxCollectionModel = TaxCollectionModel;
            this.TaxesWithheld = TaxesWithheld;
        }

        /// <summary>
        /// The tax collection model applied to the item.  Possible values:  * MarketplaceFacilitator - Tax is withheld and remitted to the taxing authority by Amazon on behalf of the seller.  * Standard - Tax is paid to the seller and not remitted to the taxing authority by Amazon.
        /// </summary>
        /// <value>The tax collection model applied to the item.  Possible values:  * MarketplaceFacilitator - Tax is withheld and remitted to the taxing authority by Amazon on behalf of the seller.  * Standard - Tax is paid to the seller and not remitted to the taxing authority by Amazon.</value>
        [DataMember(Name = "TaxCollectionModel", EmitDefaultValue = false)]
        public string TaxCollectionModel { get; set; }

        /// <summary>
        /// A list of charges that represent the types and amounts of taxes withheld.
        /// </summary>
        /// <value>A list of charges that represent the types and amounts of taxes withheld.</value>
        [DataMember(Name = "TaxesWithheld", EmitDefaultValue = false)]
        public ChargeComponentList TaxesWithheld { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaxWithheldComponent {\n");
            sb.Append("  TaxCollectionModel: ").Append(TaxCollectionModel).Append("\n");
            sb.Append("  TaxesWithheld: ").Append(TaxesWithheld).Append("\n");
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
            return this.Equals(input as TaxWithheldComponent);
        }

        /// <summary>
        /// Returns true if TaxWithheldComponent instances are equal
        /// </summary>
        /// <param name="input">Instance of TaxWithheldComponent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaxWithheldComponent input)
        {
            if (input == null)
                return false;

            return
                (
                    this.TaxCollectionModel == input.TaxCollectionModel ||
                    (this.TaxCollectionModel != null &&
                    this.TaxCollectionModel.Equals(input.TaxCollectionModel))
                ) &&
                (
                    this.TaxesWithheld == input.TaxesWithheld ||
                    (this.TaxesWithheld != null &&
                    this.TaxesWithheld.Equals(input.TaxesWithheld))
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
                if (this.TaxCollectionModel != null)
                    hashCode = hashCode * 59 + this.TaxCollectionModel.GetHashCode();
                if (this.TaxesWithheld != null)
                    hashCode = hashCode * 59 + this.TaxesWithheld.GetHashCode();
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
