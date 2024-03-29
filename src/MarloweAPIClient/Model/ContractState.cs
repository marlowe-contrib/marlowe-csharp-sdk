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
    /// ContractState
    /// </summary>
    [DataContract(Name = "ContractState")]
    public partial class ContractState : IEquatable<ContractState>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public TxStatus Status { get; set; }

        /// <summary>
        /// Gets or Sets VarVersion
        /// </summary>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = true)]
        public MarloweVersion VarVersion { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContractState" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContractState() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContractState" /> class.
        /// </summary>
        /// <param name="assets">assets (required).</param>
        /// <param name="block">block.</param>
        /// <param name="continuations">continuations.</param>
        /// <param name="contractId">A reference to a transaction output with a transaction ID and index. (required).</param>
        /// <param name="currentContract">currentContract.</param>
        /// <param name="initialContract">initialContract (required).</param>
        /// <param name="metadata">metadata (required).</param>
        /// <param name="roleTokenMintingPolicyId">The hex-encoded minting policy ID for a native Cardano token (required).</param>
        /// <param name="state">state.</param>
        /// <param name="status">status (required).</param>
        /// <param name="tags">tags (required).</param>
        /// <param name="txBody">txBody.</param>
        /// <param name="unclaimedPayouts">unclaimedPayouts (required).</param>
        /// <param name="utxo">A reference to a transaction output with a transaction ID and index..</param>
        /// <param name="varVersion">varVersion (required).</param>
        public ContractState(Assets assets = default(Assets), BlockHeader block = default(BlockHeader), string continuations = default(string), string contractId = default(string), Contract currentContract = default(Contract), Contract initialContract = default(Contract), Dictionary<string, Metadata> metadata = default(Dictionary<string, Metadata>), string roleTokenMintingPolicyId = default(string), MarloweState state = default(MarloweState), TxStatus status = default(TxStatus), Dictionary<string, Metadata> tags = default(Dictionary<string, Metadata>), TextEnvelope txBody = default(TextEnvelope), List<Payout> unclaimedPayouts = default(List<Payout>), string utxo = default(string), MarloweVersion varVersion = default(MarloweVersion))
        {
            // to ensure "assets" is required (not null)
            if (assets == null)
            {
                throw new ArgumentNullException("assets is a required property for ContractState and cannot be null");
            }
            this.Assets = assets;
            // to ensure "contractId" is required (not null)
            if (contractId == null)
            {
                throw new ArgumentNullException("contractId is a required property for ContractState and cannot be null");
            }
            this.ContractId = contractId;
            // to ensure "initialContract" is required (not null)
            if (initialContract == null)
            {
                throw new ArgumentNullException("initialContract is a required property for ContractState and cannot be null");
            }
            this.InitialContract = initialContract;
            // to ensure "metadata" is required (not null)
            if (metadata == null)
            {
                throw new ArgumentNullException("metadata is a required property for ContractState and cannot be null");
            }
            this.Metadata = metadata;
            // to ensure "roleTokenMintingPolicyId" is required (not null)
            if (roleTokenMintingPolicyId == null)
            {
                throw new ArgumentNullException("roleTokenMintingPolicyId is a required property for ContractState and cannot be null");
            }
            this.RoleTokenMintingPolicyId = roleTokenMintingPolicyId;
            this.Status = status;
            // to ensure "tags" is required (not null)
            if (tags == null)
            {
                throw new ArgumentNullException("tags is a required property for ContractState and cannot be null");
            }
            this.Tags = tags;
            // to ensure "unclaimedPayouts" is required (not null)
            if (unclaimedPayouts == null)
            {
                throw new ArgumentNullException("unclaimedPayouts is a required property for ContractState and cannot be null");
            }
            this.UnclaimedPayouts = unclaimedPayouts;
            this.VarVersion = varVersion;
            this.Block = block;
            this.Continuations = continuations;
            this.CurrentContract = currentContract;
            this.State = state;
            this.TxBody = txBody;
            this.Utxo = utxo;
        }

        /// <summary>
        /// Gets or Sets Assets
        /// </summary>
        [DataMember(Name = "assets", IsRequired = true, EmitDefaultValue = true)]
        public Assets Assets { get; set; }

        /// <summary>
        /// Gets or Sets Block
        /// </summary>
        [DataMember(Name = "block", EmitDefaultValue = false)]
        public BlockHeader Block { get; set; }

        /// <summary>
        /// Gets or Sets Continuations
        /// </summary>
        [DataMember(Name = "continuations", EmitDefaultValue = false)]
        public string Continuations { get; set; }

        /// <summary>
        /// A reference to a transaction output with a transaction ID and index.
        /// </summary>
        /// <value>A reference to a transaction output with a transaction ID and index.</value>
        /// <example>98d601c9307dd43307cf68a03aad0086d4e07a789b66919ccf9f7f7676577eb7#1</example>
        [DataMember(Name = "contractId", IsRequired = true, EmitDefaultValue = true)]
        public string ContractId { get; set; }

        /// <summary>
        /// Gets or Sets CurrentContract
        /// </summary>
        [DataMember(Name = "currentContract", EmitDefaultValue = false)]
        public Contract CurrentContract { get; set; }

        /// <summary>
        /// Gets or Sets InitialContract
        /// </summary>
        [DataMember(Name = "initialContract", IsRequired = true, EmitDefaultValue = true)]
        public Contract InitialContract { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, Metadata> Metadata { get; set; }

        /// <summary>
        /// The hex-encoded minting policy ID for a native Cardano token
        /// </summary>
        /// <value>The hex-encoded minting policy ID for a native Cardano token</value>
        [DataMember(Name = "roleTokenMintingPolicyId", IsRequired = true, EmitDefaultValue = true)]
        public string RoleTokenMintingPolicyId { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public MarloweState State { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, Metadata> Tags { get; set; }

        /// <summary>
        /// Gets or Sets TxBody
        /// </summary>
        [DataMember(Name = "txBody", EmitDefaultValue = false)]
        public TextEnvelope TxBody { get; set; }

        /// <summary>
        /// Gets or Sets UnclaimedPayouts
        /// </summary>
        [DataMember(Name = "unclaimedPayouts", IsRequired = true, EmitDefaultValue = true)]
        public List<Payout> UnclaimedPayouts { get; set; }

        /// <summary>
        /// A reference to a transaction output with a transaction ID and index.
        /// </summary>
        /// <value>A reference to a transaction output with a transaction ID and index.</value>
        /// <example>98d601c9307dd43307cf68a03aad0086d4e07a789b66919ccf9f7f7676577eb7#1</example>
        [DataMember(Name = "utxo", EmitDefaultValue = false)]
        public string Utxo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ContractState {\n");
            sb.Append("  Assets: ").Append(Assets).Append("\n");
            sb.Append("  Block: ").Append(Block).Append("\n");
            sb.Append("  Continuations: ").Append(Continuations).Append("\n");
            sb.Append("  ContractId: ").Append(ContractId).Append("\n");
            sb.Append("  CurrentContract: ").Append(CurrentContract).Append("\n");
            sb.Append("  InitialContract: ").Append(InitialContract).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  RoleTokenMintingPolicyId: ").Append(RoleTokenMintingPolicyId).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  TxBody: ").Append(TxBody).Append("\n");
            sb.Append("  UnclaimedPayouts: ").Append(UnclaimedPayouts).Append("\n");
            sb.Append("  Utxo: ").Append(Utxo).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
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
            return this.Equals(input as ContractState);
        }

        /// <summary>
        /// Returns true if ContractState instances are equal
        /// </summary>
        /// <param name="input">Instance of ContractState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContractState input)
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
                    this.Block == input.Block ||
                    (this.Block != null &&
                    this.Block.Equals(input.Block))
                ) && 
                (
                    this.Continuations == input.Continuations ||
                    (this.Continuations != null &&
                    this.Continuations.Equals(input.Continuations))
                ) && 
                (
                    this.ContractId == input.ContractId ||
                    (this.ContractId != null &&
                    this.ContractId.Equals(input.ContractId))
                ) && 
                (
                    this.CurrentContract == input.CurrentContract ||
                    (this.CurrentContract != null &&
                    this.CurrentContract.Equals(input.CurrentContract))
                ) && 
                (
                    this.InitialContract == input.InitialContract ||
                    (this.InitialContract != null &&
                    this.InitialContract.Equals(input.InitialContract))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) && 
                (
                    this.RoleTokenMintingPolicyId == input.RoleTokenMintingPolicyId ||
                    (this.RoleTokenMintingPolicyId != null &&
                    this.RoleTokenMintingPolicyId.Equals(input.RoleTokenMintingPolicyId))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.TxBody == input.TxBody ||
                    (this.TxBody != null &&
                    this.TxBody.Equals(input.TxBody))
                ) && 
                (
                    this.UnclaimedPayouts == input.UnclaimedPayouts ||
                    this.UnclaimedPayouts != null &&
                    input.UnclaimedPayouts != null &&
                    this.UnclaimedPayouts.SequenceEqual(input.UnclaimedPayouts)
                ) && 
                (
                    this.Utxo == input.Utxo ||
                    (this.Utxo != null &&
                    this.Utxo.Equals(input.Utxo))
                ) && 
                (
                    this.VarVersion == input.VarVersion ||
                    this.VarVersion.Equals(input.VarVersion)
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
                if (this.Block != null)
                {
                    hashCode = (hashCode * 59) + this.Block.GetHashCode();
                }
                if (this.Continuations != null)
                {
                    hashCode = (hashCode * 59) + this.Continuations.GetHashCode();
                }
                if (this.ContractId != null)
                {
                    hashCode = (hashCode * 59) + this.ContractId.GetHashCode();
                }
                if (this.CurrentContract != null)
                {
                    hashCode = (hashCode * 59) + this.CurrentContract.GetHashCode();
                }
                if (this.InitialContract != null)
                {
                    hashCode = (hashCode * 59) + this.InitialContract.GetHashCode();
                }
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
                }
                if (this.RoleTokenMintingPolicyId != null)
                {
                    hashCode = (hashCode * 59) + this.RoleTokenMintingPolicyId.GetHashCode();
                }
                if (this.State != null)
                {
                    hashCode = (hashCode * 59) + this.State.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                if (this.TxBody != null)
                {
                    hashCode = (hashCode * 59) + this.TxBody.GetHashCode();
                }
                if (this.UnclaimedPayouts != null)
                {
                    hashCode = (hashCode * 59) + this.UnclaimedPayouts.GetHashCode();
                }
                if (this.Utxo != null)
                {
                    hashCode = (hashCode * 59) + this.Utxo.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.VarVersion.GetHashCode();
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

            if (this.RoleTokenMintingPolicyId != null) {
                // RoleTokenMintingPolicyId (string) pattern
                Regex regexRoleTokenMintingPolicyId = new Regex(@"^[a-fA-F0-9]*$", RegexOptions.CultureInvariant);
                if (!regexRoleTokenMintingPolicyId.Match(this.RoleTokenMintingPolicyId).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RoleTokenMintingPolicyId, must match a pattern of " + regexRoleTokenMintingPolicyId, new [] { "RoleTokenMintingPolicyId" });
                }
            }

            if (this.Utxo != null) {
                // Utxo (string) pattern
                Regex regexUtxo = new Regex(@"^[a-fA-F0-9]{64}#[0-9]+$", RegexOptions.CultureInvariant);
                if (!regexUtxo.Match(this.Utxo).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Utxo, must match a pattern of " + regexUtxo, new [] { "Utxo" });
                }
            }

            yield break;
        }
    }

}
