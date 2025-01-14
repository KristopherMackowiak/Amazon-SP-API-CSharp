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
    /// A removal shipment event for a removal order.
    /// </summary>
    [DataContract]
    public partial class RemovalShipmentEvent : IEquatable<RemovalShipmentEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemovalShipmentEvent" /> class.
        /// </summary>
        /// <param name="PostedDate">The date and time when the financial event was posted..</param>
        /// <param name="OrderId">The identifier for the removal shipment order..</param>
        /// <param name="TransactionType">The type of removal order.  Possible values:  * WHOLESALE_LIQUIDATION.</param>
        /// <param name="RemovalShipmentItemList">A list of removal shipment items..</param>
        public RemovalShipmentEvent(DateTime? PostedDate = default(DateTime?), string OrderId = default(string), string TransactionType = default(string), RemovalShipmentItemList RemovalShipmentItemList = default(RemovalShipmentItemList))
        {
            this.PostedDate = PostedDate;
            this.OrderId = OrderId;
            this.TransactionType = TransactionType;
            this.RemovalShipmentItemList = RemovalShipmentItemList;
        }

        /// <summary>
        /// The date and time when the financial event was posted.
        /// </summary>
        /// <value>The date and time when the financial event was posted.</value>
        [DataMember(Name = "PostedDate", EmitDefaultValue = false)]
        public DateTime? PostedDate { get; set; }

        /// <summary>
        /// The identifier for the removal shipment order.
        /// </summary>
        /// <value>The identifier for the removal shipment order.</value>
        [DataMember(Name = "OrderId", EmitDefaultValue = false)]
        public string OrderId { get; set; }

        /// <summary>
        /// The type of removal order.  Possible values:  * WHOLESALE_LIQUIDATION
        /// </summary>
        /// <value>The type of removal order.  Possible values:  * WHOLESALE_LIQUIDATION</value>
        [DataMember(Name = "TransactionType", EmitDefaultValue = false)]
        public string TransactionType { get; set; }

        /// <summary>
        /// A list of removal shipment items.
        /// </summary>
        /// <value>A list of removal shipment items.</value>
        [DataMember(Name = "RemovalShipmentItemList", EmitDefaultValue = false)]
        public RemovalShipmentItemList RemovalShipmentItemList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RemovalShipmentEvent {\n");
            sb.Append("  PostedDate: ").Append(PostedDate).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  TransactionType: ").Append(TransactionType).Append("\n");
            sb.Append("  RemovalShipmentItemList: ").Append(RemovalShipmentItemList).Append("\n");
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
            return this.Equals(input as RemovalShipmentEvent);
        }

        /// <summary>
        /// Returns true if RemovalShipmentEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of RemovalShipmentEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RemovalShipmentEvent input)
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
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) &&
                (
                    this.TransactionType == input.TransactionType ||
                    (this.TransactionType != null &&
                    this.TransactionType.Equals(input.TransactionType))
                ) &&
                (
                    this.RemovalShipmentItemList == input.RemovalShipmentItemList ||
                    (this.RemovalShipmentItemList != null &&
                    this.RemovalShipmentItemList.Equals(input.RemovalShipmentItemList))
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
                if (this.OrderId != null)
                    hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.TransactionType != null)
                    hashCode = hashCode * 59 + this.TransactionType.GetHashCode();
                if (this.RemovalShipmentItemList != null)
                    hashCode = hashCode * 59 + this.RemovalShipmentItemList.GetHashCode();
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
