/* 
 * Selling Partner API for Sales
 *
 * The Selling Partner API for Sales provides APIs related to sales performance.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace AmazonSpApiSDK.Models.Sales
{
    /// <summary>
    /// A decimal number with no loss of precision. Useful when precision loss is unnaceptable, as with currencies. Follows RFC7159 for number representation.
    /// </summary>
    [DataContract]
    public partial class ModelDecimal : IEquatable<ModelDecimal>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelDecimal" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ModelDecimal()
        {
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelDecimal {\n");
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
            return this.Equals(input as ModelDecimal);
        }

        /// <summary>
        /// Returns true if ModelDecimal instances are equal
        /// </summary>
        /// <param name="input">Instance of ModelDecimal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModelDecimal input)
        {
            if (input == null)
                return false;

            return false;
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
