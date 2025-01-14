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
    /// An event related to coupon payments.
    /// </summary>
    [DataContract]
    public partial class CouponPaymentEvent : IEquatable<CouponPaymentEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CouponPaymentEvent" /> class.
        /// </summary>
        /// <param name="PostedDate">The date and time when the financial event was posted..</param>
        /// <param name="CouponId">A coupon identifier..</param>
        /// <param name="SellerCouponDescription">The description provided by the seller when they created the coupon..</param>
        /// <param name="ClipOrRedemptionCount">The number of coupon clips or redemptions..</param>
        /// <param name="PaymentEventId">A payment event identifier..</param>
        /// <param name="FeeComponent">FeeComponent.</param>
        /// <param name="ChargeComponent">ChargeComponent.</param>
        /// <param name="TotalAmount">The FeeComponent value plus the ChargeComponent value..</param>
        public CouponPaymentEvent(DateTime? PostedDate = default(DateTime?), string CouponId = default(string), string SellerCouponDescription = default(string), long? ClipOrRedemptionCount = default(long?), string PaymentEventId = default(string), FeeComponent FeeComponent = default(FeeComponent), ChargeComponent ChargeComponent = default(ChargeComponent), Currency TotalAmount = default(Currency))
        {
            this.PostedDate = PostedDate;
            this.CouponId = CouponId;
            this.SellerCouponDescription = SellerCouponDescription;
            this.ClipOrRedemptionCount = ClipOrRedemptionCount;
            this.PaymentEventId = PaymentEventId;
            this.FeeComponent = FeeComponent;
            this.ChargeComponent = ChargeComponent;
            this.TotalAmount = TotalAmount;
        }

        /// <summary>
        /// The date and time when the financial event was posted.
        /// </summary>
        /// <value>The date and time when the financial event was posted.</value>
        [DataMember(Name = "PostedDate", EmitDefaultValue = false)]
        public DateTime? PostedDate { get; set; }

        /// <summary>
        /// A coupon identifier.
        /// </summary>
        /// <value>A coupon identifier.</value>
        [DataMember(Name = "CouponId", EmitDefaultValue = false)]
        public string CouponId { get; set; }

        /// <summary>
        /// The description provided by the seller when they created the coupon.
        /// </summary>
        /// <value>The description provided by the seller when they created the coupon.</value>
        [DataMember(Name = "SellerCouponDescription", EmitDefaultValue = false)]
        public string SellerCouponDescription { get; set; }

        /// <summary>
        /// The number of coupon clips or redemptions.
        /// </summary>
        /// <value>The number of coupon clips or redemptions.</value>
        [DataMember(Name = "ClipOrRedemptionCount", EmitDefaultValue = false)]
        public long? ClipOrRedemptionCount { get; set; }

        /// <summary>
        /// A payment event identifier.
        /// </summary>
        /// <value>A payment event identifier.</value>
        [DataMember(Name = "PaymentEventId", EmitDefaultValue = false)]
        public string PaymentEventId { get; set; }

        /// <summary>
        /// Gets or Sets FeeComponent
        /// </summary>
        [DataMember(Name = "FeeComponent", EmitDefaultValue = false)]
        public FeeComponent FeeComponent { get; set; }

        /// <summary>
        /// Gets or Sets ChargeComponent
        /// </summary>
        [DataMember(Name = "ChargeComponent", EmitDefaultValue = false)]
        public ChargeComponent ChargeComponent { get; set; }

        /// <summary>
        /// The FeeComponent value plus the ChargeComponent value.
        /// </summary>
        /// <value>The FeeComponent value plus the ChargeComponent value.</value>
        [DataMember(Name = "TotalAmount", EmitDefaultValue = false)]
        public Currency TotalAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CouponPaymentEvent {\n");
            sb.Append("  PostedDate: ").Append(PostedDate).Append("\n");
            sb.Append("  CouponId: ").Append(CouponId).Append("\n");
            sb.Append("  SellerCouponDescription: ").Append(SellerCouponDescription).Append("\n");
            sb.Append("  ClipOrRedemptionCount: ").Append(ClipOrRedemptionCount).Append("\n");
            sb.Append("  PaymentEventId: ").Append(PaymentEventId).Append("\n");
            sb.Append("  FeeComponent: ").Append(FeeComponent).Append("\n");
            sb.Append("  ChargeComponent: ").Append(ChargeComponent).Append("\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
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
            return this.Equals(input as CouponPaymentEvent);
        }

        /// <summary>
        /// Returns true if CouponPaymentEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of CouponPaymentEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CouponPaymentEvent input)
        {
            if (input == null)
                return false;

            return
                (
                    this.PostedDate == input.PostedDate ||
                    (this.PostedDate != null &&
                    this.PostedDate.Equals(input.PostedDate))
                ) &&
                (
                    this.CouponId == input.CouponId ||
                    (this.CouponId != null &&
                    this.CouponId.Equals(input.CouponId))
                ) &&
                (
                    this.SellerCouponDescription == input.SellerCouponDescription ||
                    (this.SellerCouponDescription != null &&
                    this.SellerCouponDescription.Equals(input.SellerCouponDescription))
                ) &&
                (
                    this.ClipOrRedemptionCount == input.ClipOrRedemptionCount ||
                    (this.ClipOrRedemptionCount != null &&
                    this.ClipOrRedemptionCount.Equals(input.ClipOrRedemptionCount))
                ) &&
                (
                    this.PaymentEventId == input.PaymentEventId ||
                    (this.PaymentEventId != null &&
                    this.PaymentEventId.Equals(input.PaymentEventId))
                ) &&
                (
                    this.FeeComponent == input.FeeComponent ||
                    (this.FeeComponent != null &&
                    this.FeeComponent.Equals(input.FeeComponent))
                ) &&
                (
                    this.ChargeComponent == input.ChargeComponent ||
                    (this.ChargeComponent != null &&
                    this.ChargeComponent.Equals(input.ChargeComponent))
                ) &&
                (
                    this.TotalAmount == input.TotalAmount ||
                    (this.TotalAmount != null &&
                    this.TotalAmount.Equals(input.TotalAmount))
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
                if (this.PostedDate != null)
                    hashCode = hashCode * 59 + this.PostedDate.GetHashCode();
                if (this.CouponId != null)
                    hashCode = hashCode * 59 + this.CouponId.GetHashCode();
                if (this.SellerCouponDescription != null)
                    hashCode = hashCode * 59 + this.SellerCouponDescription.GetHashCode();
                if (this.ClipOrRedemptionCount != null)
                    hashCode = hashCode * 59 + this.ClipOrRedemptionCount.GetHashCode();
                if (this.PaymentEventId != null)
                    hashCode = hashCode * 59 + this.PaymentEventId.GetHashCode();
                if (this.FeeComponent != null)
                    hashCode = hashCode * 59 + this.FeeComponent.GetHashCode();
                if (this.ChargeComponent != null)
                    hashCode = hashCode * 59 + this.ChargeComponent.GetHashCode();
                if (this.TotalAmount != null)
                    hashCode = hashCode * 59 + this.TotalAmount.GetHashCode();
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
