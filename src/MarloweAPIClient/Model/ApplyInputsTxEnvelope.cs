/*
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
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
    /// ApplyInputsTxEnvelope
    /// </summary>
    [DataContract(Name = "ApplyInputsTxEnvelope")]
    public partial class ApplyInputsTxEnvelope : IEquatable<ApplyInputsTxEnvelope>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyInputsTxEnvelope" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApplyInputsTxEnvelope() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplyInputsTxEnvelope" /> class.
        /// </summary>
        /// <param name="tx">tx (required).</param>
        /// <param name="withdrawalId">The hex-encoded identifier of a Cardano transaction (required).</param>
        public ApplyInputsTxEnvelope(TextEnvelope tx = default(TextEnvelope), string withdrawalId = default(string))
        {
            // to ensure "tx" is required (not null)
            if (tx == null)
            {
                throw new ArgumentNullException("tx is a required property for ApplyInputsTxEnvelope and cannot be null");
            }
            this._Tx = tx;
            // to ensure "withdrawalId" is required (not null)
            if (withdrawalId == null)
            {
                throw new ArgumentNullException("withdrawalId is a required property for ApplyInputsTxEnvelope and cannot be null");
            }
            this._WithdrawalId = withdrawalId;
        }

        /// <summary>
        /// Gets or Sets Tx
        /// </summary>
        [DataMember(Name = "tx", IsRequired = true, EmitDefaultValue = true)]
        public TextEnvelope Tx
        {
            get{ return _Tx;}
            set
            {
                _Tx = value;
                _flagTx = true;
            }
        }
        private TextEnvelope _Tx;
        private bool _flagTx;

        /// <summary>
        /// Returns false as Tx should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTx()
        {
            return _flagTx;
        }
        /// <summary>
        /// The hex-encoded identifier of a Cardano transaction
        /// </summary>
        /// <value>The hex-encoded identifier of a Cardano transaction</value>
        [DataMember(Name = "withdrawalId", IsRequired = true, EmitDefaultValue = true)]
        public string WithdrawalId
        {
            get{ return _WithdrawalId;}
            set
            {
                _WithdrawalId = value;
                _flagWithdrawalId = true;
            }
        }
        private string _WithdrawalId;
        private bool _flagWithdrawalId;

        /// <summary>
        /// Returns false as WithdrawalId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeWithdrawalId()
        {
            return _flagWithdrawalId;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApplyInputsTxEnvelope {\n");
            sb.Append("  Tx: ").Append(Tx).Append("\n");
            sb.Append("  WithdrawalId: ").Append(WithdrawalId).Append("\n");
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
            return this.Equals(input as ApplyInputsTxEnvelope);
        }

        /// <summary>
        /// Returns true if ApplyInputsTxEnvelope instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplyInputsTxEnvelope to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplyInputsTxEnvelope input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Tx == input.Tx ||
                    (this.Tx != null &&
                    this.Tx.Equals(input.Tx))
                ) && 
                (
                    this.WithdrawalId == input.WithdrawalId ||
                    (this.WithdrawalId != null &&
                    this.WithdrawalId.Equals(input.WithdrawalId))
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
                if (this.Tx != null)
                {
                    hashCode = (hashCode * 59) + this.Tx.GetHashCode();
                }
                if (this.WithdrawalId != null)
                {
                    hashCode = (hashCode * 59) + this.WithdrawalId.GetHashCode();
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
            if (this.WithdrawalId != null) {
                // WithdrawalId (string) pattern
                Regex regexWithdrawalId = new Regex(@"^[a-fA-F0-9]{64}$", RegexOptions.CultureInvariant);
                if (!regexWithdrawalId.Match(this.WithdrawalId).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for WithdrawalId, must match a pattern of " + regexWithdrawalId, new [] { "WithdrawalId" });
                }
            }

            yield break;
        }
    }

}
