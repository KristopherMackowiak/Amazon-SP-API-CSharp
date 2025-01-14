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
    /// An event related to a rental transaction.
    /// </summary>
    [DataContract]
    public partial class RentalTransactionEvent : IEquatable<RentalTransactionEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RentalTransactionEvent" /> class.
        /// </summary>
        /// <param name="AmazonOrderId">An Amazon-defined identifier for an order..</param>
        /// <param name="RentalEventType">The type of rental event.  Possible values:  * RentalCustomerPayment-Buyout - Transaction type that represents when the customer wants to buy out a rented item.  * RentalCustomerPayment-Extension - Transaction type that represents when the customer wants to extend the rental period.  * RentalCustomerRefund-Buyout - Transaction type that represents when the customer requests a refund for the buyout of the rented item.  * RentalCustomerRefund-Extension - Transaction type that represents when the customer requests a refund over the extension on the rented item.  * RentalHandlingFee - Transaction type that represents the fee that Amazon charges sellers who rent through Amazon.  * RentalChargeFailureReimbursement - Transaction type that represents when Amazon sends money to the seller to compensate for a failed charge.  * RentalLostItemReimbursement - Transaction type that represents when Amazon sends money to the seller to compensate for a lost item..</param>
        /// <param name="ExtensionLength">The number of days that the buyer extended an already rented item. This value is only returned for RentalCustomerPayment-Extension and RentalCustomerRefund-Extension events..</param>
        /// <param name="PostedDate">The date and time when the financial event was posted..</param>
        /// <param name="RentalChargeList">A list of charges associated with the rental event..</param>
        /// <param name="RentalFeeList">A list of fees associated with the rental event..</param>
        /// <param name="MarketplaceName">The name of the marketplace..</param>
        /// <param name="RentalInitialValue">The amount of money the customer originally paid to rent the item. This value is only returned for RentalChargeFailureReimbursement and RentalLostItemReimbursement events..</param>
        /// <param name="RentalReimbursement">The amount of money Amazon sends the seller to compensate for a lost item or a failed charge. This value is only returned for RentalChargeFailureReimbursement and RentalLostItemReimbursement events..</param>
        /// <param name="RentalTaxWithheldList">A list of taxes withheld information for a rental item..</param>
        public RentalTransactionEvent(string AmazonOrderId = default(string), string RentalEventType = default(string), int? ExtensionLength = default(int?), DateTime? PostedDate = default(DateTime?), ChargeComponentList RentalChargeList = default(ChargeComponentList), FeeComponentList RentalFeeList = default(FeeComponentList), string MarketplaceName = default(string), Currency RentalInitialValue = default(Currency), Currency RentalReimbursement = default(Currency), TaxWithheldComponentList RentalTaxWithheldList = default(TaxWithheldComponentList))
        {
            this.AmazonOrderId = AmazonOrderId;
            this.RentalEventType = RentalEventType;
            this.ExtensionLength = ExtensionLength;
            this.PostedDate = PostedDate;
            this.RentalChargeList = RentalChargeList;
            this.RentalFeeList = RentalFeeList;
            this.MarketplaceName = MarketplaceName;
            this.RentalInitialValue = RentalInitialValue;
            this.RentalReimbursement = RentalReimbursement;
            this.RentalTaxWithheldList = RentalTaxWithheldList;
        }

        /// <summary>
        /// An Amazon-defined identifier for an order.
        /// </summary>
        /// <value>An Amazon-defined identifier for an order.</value>
        [DataMember(Name = "AmazonOrderId", EmitDefaultValue = false)]
        public string AmazonOrderId { get; set; }

        /// <summary>
        /// The type of rental event.  Possible values:  * RentalCustomerPayment-Buyout - Transaction type that represents when the customer wants to buy out a rented item.  * RentalCustomerPayment-Extension - Transaction type that represents when the customer wants to extend the rental period.  * RentalCustomerRefund-Buyout - Transaction type that represents when the customer requests a refund for the buyout of the rented item.  * RentalCustomerRefund-Extension - Transaction type that represents when the customer requests a refund over the extension on the rented item.  * RentalHandlingFee - Transaction type that represents the fee that Amazon charges sellers who rent through Amazon.  * RentalChargeFailureReimbursement - Transaction type that represents when Amazon sends money to the seller to compensate for a failed charge.  * RentalLostItemReimbursement - Transaction type that represents when Amazon sends money to the seller to compensate for a lost item.
        /// </summary>
        /// <value>The type of rental event.  Possible values:  * RentalCustomerPayment-Buyout - Transaction type that represents when the customer wants to buy out a rented item.  * RentalCustomerPayment-Extension - Transaction type that represents when the customer wants to extend the rental period.  * RentalCustomerRefund-Buyout - Transaction type that represents when the customer requests a refund for the buyout of the rented item.  * RentalCustomerRefund-Extension - Transaction type that represents when the customer requests a refund over the extension on the rented item.  * RentalHandlingFee - Transaction type that represents the fee that Amazon charges sellers who rent through Amazon.  * RentalChargeFailureReimbursement - Transaction type that represents when Amazon sends money to the seller to compensate for a failed charge.  * RentalLostItemReimbursement - Transaction type that represents when Amazon sends money to the seller to compensate for a lost item.</value>
        [DataMember(Name = "RentalEventType", EmitDefaultValue = false)]
        public string RentalEventType { get; set; }

        /// <summary>
        /// The number of days that the buyer extended an already rented item. This value is only returned for RentalCustomerPayment-Extension and RentalCustomerRefund-Extension events.
        /// </summary>
        /// <value>The number of days that the buyer extended an already rented item. This value is only returned for RentalCustomerPayment-Extension and RentalCustomerRefund-Extension events.</value>
        [DataMember(Name = "ExtensionLength", EmitDefaultValue = false)]
        public int? ExtensionLength { get; set; }

        /// <summary>
        /// The date and time when the financial event was posted.
        /// </summary>
        /// <value>The date and time when the financial event was posted.</value>
        [DataMember(Name = "PostedDate", EmitDefaultValue = false)]
        public DateTime? PostedDate { get; set; }

        /// <summary>
        /// A list of charges associated with the rental event.
        /// </summary>
        /// <value>A list of charges associated with the rental event.</value>
        [DataMember(Name = "RentalChargeList", EmitDefaultValue = false)]
        public ChargeComponentList RentalChargeList { get; set; }

        /// <summary>
        /// A list of fees associated with the rental event.
        /// </summary>
        /// <value>A list of fees associated with the rental event.</value>
        [DataMember(Name = "RentalFeeList", EmitDefaultValue = false)]
        public FeeComponentList RentalFeeList { get; set; }

        /// <summary>
        /// The name of the marketplace.
        /// </summary>
        /// <value>The name of the marketplace.</value>
        [DataMember(Name = "MarketplaceName", EmitDefaultValue = false)]
        public string MarketplaceName { get; set; }

        /// <summary>
        /// The amount of money the customer originally paid to rent the item. This value is only returned for RentalChargeFailureReimbursement and RentalLostItemReimbursement events.
        /// </summary>
        /// <value>The amount of money the customer originally paid to rent the item. This value is only returned for RentalChargeFailureReimbursement and RentalLostItemReimbursement events.</value>
        [DataMember(Name = "RentalInitialValue", EmitDefaultValue = false)]
        public Currency RentalInitialValue { get; set; }

        /// <summary>
        /// The amount of money Amazon sends the seller to compensate for a lost item or a failed charge. This value is only returned for RentalChargeFailureReimbursement and RentalLostItemReimbursement events.
        /// </summary>
        /// <value>The amount of money Amazon sends the seller to compensate for a lost item or a failed charge. This value is only returned for RentalChargeFailureReimbursement and RentalLostItemReimbursement events.</value>
        [DataMember(Name = "RentalReimbursement", EmitDefaultValue = false)]
        public Currency RentalReimbursement { get; set; }

        /// <summary>
        /// A list of taxes withheld information for a rental item.
        /// </summary>
        /// <value>A list of taxes withheld information for a rental item.</value>
        [DataMember(Name = "RentalTaxWithheldList", EmitDefaultValue = false)]
        public TaxWithheldComponentList RentalTaxWithheldList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RentalTransactionEvent {\n");
            sb.Append("  AmazonOrderId: ").Append(AmazonOrderId).Append("\n");
            sb.Append("  RentalEventType: ").Append(RentalEventType).Append("\n");
            sb.Append("  ExtensionLength: ").Append(ExtensionLength).Append("\n");
            sb.Append("  PostedDate: ").Append(PostedDate).Append("\n");
            sb.Append("  RentalChargeList: ").Append(RentalChargeList).Append("\n");
            sb.Append("  RentalFeeList: ").Append(RentalFeeList).Append("\n");
            sb.Append("  MarketplaceName: ").Append(MarketplaceName).Append("\n");
            sb.Append("  RentalInitialValue: ").Append(RentalInitialValue).Append("\n");
            sb.Append("  RentalReimbursement: ").Append(RentalReimbursement).Append("\n");
            sb.Append("  RentalTaxWithheldList: ").Append(RentalTaxWithheldList).Append("\n");
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
            return this.Equals(input as RentalTransactionEvent);
        }

        /// <summary>
        /// Returns true if RentalTransactionEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of RentalTransactionEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RentalTransactionEvent input)
        {
            if (input == null)
                return false;

            return
                (
                    this.AmazonOrderId == input.AmazonOrderId ||
                    (this.AmazonOrderId != null &&
                    this.AmazonOrderId.Equals(input.AmazonOrderId))
                ) &&
                (
                    this.RentalEventType == input.RentalEventType ||
                    (this.RentalEventType != null &&
                    this.RentalEventType.Equals(input.RentalEventType))
                ) &&
                (
                    this.ExtensionLength == input.ExtensionLength ||
                    (this.ExtensionLength != null &&
                    this.ExtensionLength.Equals(input.ExtensionLength))
                ) &&
                (
                    this.PostedDate == input.PostedDate ||
                    (this.PostedDate != null &&
                    this.PostedDate.Equals(input.PostedDate))
                ) &&
                (
                    this.RentalChargeList == input.RentalChargeList ||
                    (this.RentalChargeList != null &&
                    this.RentalChargeList.Equals(input.RentalChargeList))
                ) &&
                (
                    this.RentalFeeList == input.RentalFeeList ||
                    (this.RentalFeeList != null &&
                    this.RentalFeeList.Equals(input.RentalFeeList))
                ) &&
                (
                    this.MarketplaceName == input.MarketplaceName ||
                    (this.MarketplaceName != null &&
                    this.MarketplaceName.Equals(input.MarketplaceName))
                ) &&
                (
                    this.RentalInitialValue == input.RentalInitialValue ||
                    (this.RentalInitialValue != null &&
                    this.RentalInitialValue.Equals(input.RentalInitialValue))
                ) &&
                (
                    this.RentalReimbursement == input.RentalReimbursement ||
                    (this.RentalReimbursement != null &&
                    this.RentalReimbursement.Equals(input.RentalReimbursement))
                ) &&
                (
                    this.RentalTaxWithheldList == input.RentalTaxWithheldList ||
                    (this.RentalTaxWithheldList != null &&
                    this.RentalTaxWithheldList.Equals(input.RentalTaxWithheldList))
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
                if (this.AmazonOrderId != null)
                    hashCode = hashCode * 59 + this.AmazonOrderId.GetHashCode();
                if (this.RentalEventType != null)
                    hashCode = hashCode * 59 + this.RentalEventType.GetHashCode();
                if (this.ExtensionLength != null)
                    hashCode = hashCode * 59 + this.ExtensionLength.GetHashCode();
                if (this.PostedDate != null)
                    hashCode = hashCode * 59 + this.PostedDate.GetHashCode();
                if (this.RentalChargeList != null)
                    hashCode = hashCode * 59 + this.RentalChargeList.GetHashCode();
                if (this.RentalFeeList != null)
                    hashCode = hashCode * 59 + this.RentalFeeList.GetHashCode();
                if (this.MarketplaceName != null)
                    hashCode = hashCode * 59 + this.MarketplaceName.GetHashCode();
                if (this.RentalInitialValue != null)
                    hashCode = hashCode * 59 + this.RentalInitialValue.GetHashCode();
                if (this.RentalReimbursement != null)
                    hashCode = hashCode * 59 + this.RentalReimbursement.GetHashCode();
                if (this.RentalTaxWithheldList != null)
                    hashCode = hashCode * 59 + this.RentalTaxWithheldList.GetHashCode();
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
