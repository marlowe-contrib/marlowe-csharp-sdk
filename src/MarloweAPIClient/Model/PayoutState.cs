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
    /// PayoutState
    /// </summary>
    [DataContract(Name = "PayoutState")]
    public partial class PayoutState : IEquatable<PayoutState>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>

        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public PayoutStatus Status
        {
            get{ return _Status;}
            set
            {
                _Status = value;
                _flagStatus = true;
            }
        }
        private PayoutStatus _Status;
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
        /// Initializes a new instance of the <see cref="PayoutState" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PayoutState() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PayoutState" /> class.
        /// </summary>
        /// <param name="assets">assets (required).</param>
        /// <param name="contractId">A reference to a transaction output with a transaction ID and index. (required).</param>
        /// <param name="payoutId">A reference to a transaction output with a transaction ID and index. (required).</param>
        /// <param name="payoutValidatorAddress">A cardano address, in Bech32 format (required).</param>
        /// <param name="role">role (required).</param>
        /// <param name="status">status (required).</param>
        /// <param name="withdrawalId">The hex-encoded identifier of a Cardano transaction.</param>
        public PayoutState(Assets assets = default(Assets), string contractId = default(string), string payoutId = default(string), string payoutValidatorAddress = default(string), AssetId role = default(AssetId), PayoutStatus status = default(PayoutStatus), string withdrawalId = default(string))
        {
            // to ensure "assets" is required (not null)
            if (assets == null)
            {
                throw new ArgumentNullException("assets is a required property for PayoutState and cannot be null");
            }
            this._Assets = assets;
            // to ensure "contractId" is required (not null)
            if (contractId == null)
            {
                throw new ArgumentNullException("contractId is a required property for PayoutState and cannot be null");
            }
            this._ContractId = contractId;
            // to ensure "payoutId" is required (not null)
            if (payoutId == null)
            {
                throw new ArgumentNullException("payoutId is a required property for PayoutState and cannot be null");
            }
            this._PayoutId = payoutId;
            // to ensure "payoutValidatorAddress" is required (not null)
            if (payoutValidatorAddress == null)
            {
                throw new ArgumentNullException("payoutValidatorAddress is a required property for PayoutState and cannot be null");
            }
            this._PayoutValidatorAddress = payoutValidatorAddress;
            // to ensure "role" is required (not null)
            if (role == null)
            {
                throw new ArgumentNullException("role is a required property for PayoutState and cannot be null");
            }
            this._Role = role;
            this._Status = status;
            this._WithdrawalId = withdrawalId;
            if (this.WithdrawalId != null)
            {
                this._flagWithdrawalId = true;
            }
        }

        /// <summary>
        /// Gets or Sets Assets
        /// </summary>
        [DataMember(Name = "assets", IsRequired = true, EmitDefaultValue = true)]
        public Assets Assets
        {
            get{ return _Assets;}
            set
            {
                _Assets = value;
                _flagAssets = true;
            }
        }
        private Assets _Assets;
        private bool _flagAssets;

        /// <summary>
        /// Returns false as Assets should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAssets()
        {
            return _flagAssets;
        }
        /// <summary>
        /// A reference to a transaction output with a transaction ID and index.
        /// </summary>
        /// <value>A reference to a transaction output with a transaction ID and index.</value>
        /// <example>98d601c9307dd43307cf68a03aad0086d4e07a789b66919ccf9f7f7676577eb7#1</example>
        [DataMember(Name = "contractId", IsRequired = true, EmitDefaultValue = true)]
        public string ContractId
        {
            get{ return _ContractId;}
            set
            {
                _ContractId = value;
                _flagContractId = true;
            }
        }
        private string _ContractId;
        private bool _flagContractId;

        /// <summary>
        /// Returns false as ContractId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeContractId()
        {
            return _flagContractId;
        }
        /// <summary>
        /// A reference to a transaction output with a transaction ID and index.
        /// </summary>
        /// <value>A reference to a transaction output with a transaction ID and index.</value>
        /// <example>98d601c9307dd43307cf68a03aad0086d4e07a789b66919ccf9f7f7676577eb7#1</example>
        [DataMember(Name = "payoutId", IsRequired = true, EmitDefaultValue = true)]
        public string PayoutId
        {
            get{ return _PayoutId;}
            set
            {
                _PayoutId = value;
                _flagPayoutId = true;
            }
        }
        private string _PayoutId;
        private bool _flagPayoutId;

        /// <summary>
        /// Returns false as PayoutId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePayoutId()
        {
            return _flagPayoutId;
        }
        /// <summary>
        /// A cardano address, in Bech32 format
        /// </summary>
        /// <value>A cardano address, in Bech32 format</value>
        /// <example>addr1w94f8ywk4fg672xasahtk4t9k6w3aql943uxz5rt62d4dvq8evxaf</example>
        [DataMember(Name = "payoutValidatorAddress", IsRequired = true, EmitDefaultValue = true)]
        public string PayoutValidatorAddress
        {
            get{ return _PayoutValidatorAddress;}
            set
            {
                _PayoutValidatorAddress = value;
                _flagPayoutValidatorAddress = true;
            }
        }
        private string _PayoutValidatorAddress;
        private bool _flagPayoutValidatorAddress;

        /// <summary>
        /// Returns false as PayoutValidatorAddress should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePayoutValidatorAddress()
        {
            return _flagPayoutValidatorAddress;
        }
        /// <summary>
        /// Gets or Sets Role
        /// </summary>
        [DataMember(Name = "role", IsRequired = true, EmitDefaultValue = true)]
        public AssetId Role
        {
            get{ return _Role;}
            set
            {
                _Role = value;
                _flagRole = true;
            }
        }
        private AssetId _Role;
        private bool _flagRole;

        /// <summary>
        /// Returns false as Role should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRole()
        {
            return _flagRole;
        }
        /// <summary>
        /// The hex-encoded identifier of a Cardano transaction
        /// </summary>
        /// <value>The hex-encoded identifier of a Cardano transaction</value>
        [DataMember(Name = "withdrawalId", EmitDefaultValue = false)]
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
            sb.Append("class PayoutState {\n");
            sb.Append("  Assets: ").Append(Assets).Append("\n");
            sb.Append("  ContractId: ").Append(ContractId).Append("\n");
            sb.Append("  PayoutId: ").Append(PayoutId).Append("\n");
            sb.Append("  PayoutValidatorAddress: ").Append(PayoutValidatorAddress).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
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
            return this.Equals(input as PayoutState);
        }

        /// <summary>
        /// Returns true if PayoutState instances are equal
        /// </summary>
        /// <param name="input">Instance of PayoutState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayoutState input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Assets == input.Assets ||
                    (this.Assets != null &&
                    this.Assets.Equals(input.Assets))
                ) && 
                (
                    this.ContractId == input.ContractId ||
                    (this.ContractId != null &&
                    this.ContractId.Equals(input.ContractId))
                ) && 
                (
                    this.PayoutId == input.PayoutId ||
                    (this.PayoutId != null &&
                    this.PayoutId.Equals(input.PayoutId))
                ) && 
                (
                    this.PayoutValidatorAddress == input.PayoutValidatorAddress ||
                    (this.PayoutValidatorAddress != null &&
                    this.PayoutValidatorAddress.Equals(input.PayoutValidatorAddress))
                ) && 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
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
                if (this.Assets != null)
                {
                    hashCode = (hashCode * 59) + this.Assets.GetHashCode();
                }
                if (this.ContractId != null)
                {
                    hashCode = (hashCode * 59) + this.ContractId.GetHashCode();
                }
                if (this.PayoutId != null)
                {
                    hashCode = (hashCode * 59) + this.PayoutId.GetHashCode();
                }
                if (this.PayoutValidatorAddress != null)
                {
                    hashCode = (hashCode * 59) + this.PayoutValidatorAddress.GetHashCode();
                }
                if (this.Role != null)
                {
                    hashCode = (hashCode * 59) + this.Role.GetHashCode();
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
            if (this.ContractId != null) {
                // ContractId (string) pattern
                Regex regexContractId = new Regex(@"^[a-fA-F0-9]{64}#[0-9]+$", RegexOptions.CultureInvariant);
                if (!regexContractId.Match(this.ContractId).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ContractId, must match a pattern of " + regexContractId, new [] { "ContractId" });
                }
            }

            if (this.PayoutId != null) {
                // PayoutId (string) pattern
                Regex regexPayoutId = new Regex(@"^[a-fA-F0-9]{64}#[0-9]+$", RegexOptions.CultureInvariant);
                if (!regexPayoutId.Match(this.PayoutId).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PayoutId, must match a pattern of " + regexPayoutId, new [] { "PayoutId" });
                }
            }

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
