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
    /// A debt payment or debt adjustment.
    /// </summary>
    [DataContract]
    public partial class DebtRecoveryEvent : IEquatable<DebtRecoveryEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DebtRecoveryEvent" /> class.
        /// </summary>
        /// <param name="DebtRecoveryType">The debt recovery type.  Possible values:  * DebtPayment  * DebtPaymentFailure  *DebtAdjustment.</param>
        /// <param name="RecoveryAmount">The amount applied for recovery..</param>
        /// <param name="OverPaymentCredit">The amount returned for overpayment..</param>
        /// <param name="DebtRecoveryItemList">DebtRecoveryItemList.</param>
        /// <param name="ChargeInstrumentList">ChargeInstrumentList.</param>
        public DebtRecoveryEvent(string DebtRecoveryType = default(string), Currency RecoveryAmount = default(Currency), Currency OverPaymentCredit = default(Currency), DebtRecoveryItemList DebtRecoveryItemList = default(DebtRecoveryItemList), ChargeInstrumentList ChargeInstrumentList = default(ChargeInstrumentList))
        {
            this.DebtRecoveryType = DebtRecoveryType;
            this.RecoveryAmount = RecoveryAmount;
            this.OverPaymentCredit = OverPaymentCredit;
            this.DebtRecoveryItemList = DebtRecoveryItemList;
            this.ChargeInstrumentList = ChargeInstrumentList;
        }

        /// <summary>
        /// The debt recovery type.  Possible values:  * DebtPayment  * DebtPaymentFailure  *DebtAdjustment
        /// </summary>
        /// <value>The debt recovery type.  Possible values:  * DebtPayment  * DebtPaymentFailure  *DebtAdjustment</value>
        [DataMember(Name = "DebtRecoveryType", EmitDefaultValue = false)]
        public string DebtRecoveryType { get; set; }

        /// <summary>
        /// The amount applied for recovery.
        /// </summary>
        /// <value>The amount applied for recovery.</value>
        [DataMember(Name = "RecoveryAmount", EmitDefaultValue = false)]
        public Currency RecoveryAmount { get; set; }

        /// <summary>
        /// The amount returned for overpayment.
        /// </summary>
        /// <value>The amount returned for overpayment.</value>
        [DataMember(Name = "OverPaymentCredit", EmitDefaultValue = false)]
        public Currency OverPaymentCredit { get; set; }

        /// <summary>
        /// Gets or Sets DebtRecoveryItemList
        /// </summary>
        [DataMember(Name = "DebtRecoveryItemList", EmitDefaultValue = false)]
        public DebtRecoveryItemList DebtRecoveryItemList { get; set; }

        /// <summary>
        /// Gets or Sets ChargeInstrumentList
        /// </summary>
        [DataMember(Name = "ChargeInstrumentList", EmitDefaultValue = false)]
        public ChargeInstrumentList ChargeInstrumentList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DebtRecoveryEvent {\n");
            sb.Append("  DebtRecoveryType: ").Append(DebtRecoveryType).Append("\n");
            sb.Append("  RecoveryAmount: ").Append(RecoveryAmount).Append("\n");
            sb.Append("  OverPaymentCredit: ").Append(OverPaymentCredit).Append("\n");
            sb.Append("  DebtRecoveryItemList: ").Append(DebtRecoveryItemList).Append("\n");
            sb.Append("  ChargeInstrumentList: ").Append(ChargeInstrumentList).Append("\n");
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
            return this.Equals(input as DebtRecoveryEvent);
        }

        /// <summary>
        /// Returns true if DebtRecoveryEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of DebtRecoveryEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DebtRecoveryEvent input)
        {
            if (input == null)
                return false;

            return
                (
                    this.DebtRecoveryType == input.DebtRecoveryType ||
                    (this.DebtRecoveryType != null &&
                    this.DebtRecoveryType.Equals(input.DebtRecoveryType))
                ) &&
                (
                    this.RecoveryAmount == input.RecoveryAmount ||
                    (this.RecoveryAmount != null &&
                    this.RecoveryAmount.Equals(input.RecoveryAmount))
                ) &&
                (
                    this.OverPaymentCredit == input.OverPaymentCredit ||
                    (this.OverPaymentCredit != null &&
                    this.OverPaymentCredit.Equals(input.OverPaymentCredit))
                ) &&
                (
                    this.DebtRecoveryItemList == input.DebtRecoveryItemList ||
                    (this.DebtRecoveryItemList != null &&
                    this.DebtRecoveryItemList.Equals(input.DebtRecoveryItemList))
                ) &&
                (
                    this.ChargeInstrumentList == input.ChargeInstrumentList ||
                    (this.ChargeInstrumentList != null &&
                    this.ChargeInstrumentList.Equals(input.ChargeInstrumentList))
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
                if (this.DebtRecoveryType != null)
                    hashCode = hashCode * 59 + this.DebtRecoveryType.GetHashCode();
                if (this.RecoveryAmount != null)
                    hashCode = hashCode * 59 + this.RecoveryAmount.GetHashCode();
                if (this.OverPaymentCredit != null)
                    hashCode = hashCode * 59 + this.OverPaymentCredit.GetHashCode();
                if (this.DebtRecoveryItemList != null)
                    hashCode = hashCode * 59 + this.DebtRecoveryItemList.GetHashCode();
                if (this.ChargeInstrumentList != null)
                    hashCode = hashCode * 59 + this.ChargeInstrumentList.GetHashCode();
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
