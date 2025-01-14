/* 
 * Selling Partner API for FBA Small And Light
 *
 * The Selling Partner API for FBA Small and Light lets you help sellers manage their listings in the Small and Light program. The program reduces the cost of fulfilling orders for small and lightweight FBA inventory. You can enroll or remove items from the program and check item eligibility and enrollment status. You can also preview the estimated program fees charged to a seller for items sold while enrolled in the program.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace AmazonSpApiSDK.Models.FbaSmallandLight
{
    /// <summary>
    /// The Small and Light enrollment status of the item.
    /// </summary>
    /// <value>The Small and Light enrollment status of the item.</value>

    [JsonConverter(typeof(StringEnumConverter))]

    public enum SmallAndLightEnrollmentStatus
    {

        /// <summary>
        /// Enum ENROLLED for value: ENROLLED
        /// </summary>
        [EnumMember(Value = "ENROLLED")]
        ENROLLED = 1,

        /// <summary>
        /// Enum NOTENROLLED for value: NOT_ENROLLED
        /// </summary>
        [EnumMember(Value = "NOT_ENROLLED")]
        NOTENROLLED = 2
    }

}
