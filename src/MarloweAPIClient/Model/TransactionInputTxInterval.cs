/*
 * Marlowe Runtime REST API
 *
 * REST API for Marlowe Runtime
 *
 * The version of the OpenAPI document: 0.0.5.1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = MarloweAPIClient.Client.OpenAPIDateConverter;

namespace MarloweAPIClient.Model
{
    /// <summary>
    /// Time interval.
    /// </summary>
    [DataContract(Name = "TransactionInput_tx_interval")]
    public partial class TransactionInputTxInterval : IEquatable<TransactionInputTxInterval>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionInputTxInterval" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionInputTxInterval() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionInputTxInterval" /> class.
        /// </summary>
        /// <param name="from">from (required).</param>
        /// <param name="to">to (required).</param>
        public TransactionInputTxInterval(int from = default(int), int to = default(int))
        {
            this.From = from;
            this.To = to;
        }

        /// <summary>
        /// Gets or Sets From
        /// </summary>
        [DataMember(Name = "from", IsRequired = true, EmitDefaultValue = true)]
        public int From { get; set; }

        /// <summary>
        /// Gets or Sets To
        /// </summary>
        [DataMember(Name = "to", IsRequired = true, EmitDefaultValue = true)]
        public int To { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransactionInputTxInterval {\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TransactionInputTxInterval);
        }

        /// <summary>
        /// Returns true if TransactionInputTxInterval instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionInputTxInterval to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionInputTxInterval input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.From == input.From ||
                    this.From.Equals(input.From)
                ) && 
                (
                    this.To == input.To ||
                    this.To.Equals(input.To)
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
                hashCode = (hashCode * 59) + this.From.GetHashCode();
                hashCode = (hashCode * 59) + this.To.GetHashCode();
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
