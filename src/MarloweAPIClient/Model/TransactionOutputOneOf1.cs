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
    /// Marlowe transaction error.
    /// </summary>
    [DataContract(Name = "TransactionOutput_oneOf_1")]
    public partial class TransactionOutputOneOf1 : IEquatable<TransactionOutputOneOf1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionOutputOneOf1" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionOutputOneOf1() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionOutputOneOf1" /> class.
        /// </summary>
        /// <param name="transactionError">transactionError (required).</param>
        public TransactionOutputOneOf1(TransactionError transactionError = default(TransactionError))
        {
            // to ensure "transactionError" is required (not null)
            if (transactionError == null)
            {
                throw new ArgumentNullException("transactionError is a required property for TransactionOutputOneOf1 and cannot be null");
            }
            this._TransactionError = transactionError;
        }

        /// <summary>
        /// Gets or Sets TransactionError
        /// </summary>
        [DataMember(Name = "transaction_error", IsRequired = true, EmitDefaultValue = true)]
        public TransactionError TransactionError
        {
            get{ return _TransactionError;}
            set
            {
                _TransactionError = value;
                _flagTransactionError = true;
            }
        }
        private TransactionError _TransactionError;
        private bool _flagTransactionError;

        /// <summary>
        /// Returns false as TransactionError should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTransactionError()
        {
            return _flagTransactionError;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransactionOutputOneOf1 {\n");
            sb.Append("  TransactionError: ").Append(TransactionError).Append("\n");
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
            return this.Equals(input as TransactionOutputOneOf1);
        }

        /// <summary>
        /// Returns true if TransactionOutputOneOf1 instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionOutputOneOf1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionOutputOneOf1 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TransactionError == input.TransactionError ||
                    (this.TransactionError != null &&
                    this.TransactionError.Equals(input.TransactionError))
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
                if (this.TransactionError != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionError.GetHashCode();
                }
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
