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
    /// WithdrawalHeader
    /// </summary>
    [DataContract(Name = "WithdrawalHeader")]
    public partial class WithdrawalHeader : IEquatable<WithdrawalHeader>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>

        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public TxStatus Status
        {
            get{ return _Status;}
            set
            {
                _Status = value;
                _flagStatus = true;
            }
        }
        private TxStatus _Status;
        private bool _flagStatus;

        /// <summary>
        /// Returns false as Status should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeStatus()
        {
            return _flagStatus;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="WithdrawalHeader" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WithdrawalHeader() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WithdrawalHeader" /> class.
        /// </summary>
        /// <param name="block">block.</param>
        /// <param name="status">status (required).</param>
        /// <param name="withdrawalId">The hex-encoded identifier of a Cardano transaction (required).</param>
        public WithdrawalHeader(BlockHeader block = default(BlockHeader), TxStatus status = default(TxStatus), string withdrawalId = default(string))
        {
            this._Status = status;
            // to ensure "withdrawalId" is required (not null)
            if (withdrawalId == null)
            {
                throw new ArgumentNullException("withdrawalId is a required property for WithdrawalHeader and cannot be null");
            }
            this._WithdrawalId = withdrawalId;
            this._Block = block;
            if (this.Block != null)
            {
                this._flagBlock = true;
            }
        }

        /// <summary>
        /// Gets or Sets Block
        /// </summary>
        [DataMember(Name = "block", EmitDefaultValue = false)]
        public BlockHeader Block
        {
            get{ return _Block;}
            set
            {
                _Block = value;
                _flagBlock = true;
            }
        }
        private BlockHeader _Block;
        private bool _flagBlock;

        /// <summary>
        /// Returns false as Block should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeBlock()
        {
            return _flagBlock;
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
            sb.Append("class WithdrawalHeader {\n");
            sb.Append("  Block: ").Append(Block).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as WithdrawalHeader);
        }

        /// <summary>
        /// Returns true if WithdrawalHeader instances are equal
        /// </summary>
        /// <param name="input">Instance of WithdrawalHeader to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WithdrawalHeader input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Block == input.Block ||
                    (this.Block != null &&
                    this.Block.Equals(input.Block))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
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
                if (this.Block != null)
                {
                    hashCode = (hashCode * 59) + this.Block.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
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
