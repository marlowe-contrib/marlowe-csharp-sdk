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
    /// Information about the safety of a Marlowe contract and its state.
    /// </summary>
    [DataContract(Name = "SafetyError")]
    public partial class SafetyError : IEquatable<SafetyError>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SafetyError" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SafetyError() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SafetyError" /> class.
        /// </summary>
        /// <param name="accountId">accountId.</param>
        /// <param name="address">address.</param>
        /// <param name="bytes">bytes.</param>
        /// <param name="choiceId">choiceId.</param>
        /// <param name="cost">cost.</param>
        /// <param name="currencySymbol">currencySymbol.</param>
        /// <param name="detail">detail (required).</param>
        /// <param name="error">error (required).</param>
        /// <param name="fatal">fatal (required).</param>
        /// <param name="hash">hash.</param>
        /// <param name="message">message.</param>
        /// <param name="roleName">roleName.</param>
        /// <param name="token">token.</param>
        /// <param name="tokenName">tokenName.</param>
        /// <param name="transaction">transaction.</param>
        /// <param name="valueId">valueId.</param>
        /// <param name="warning">warning.</param>
        public SafetyError(Party accountId = default(Party), PlutusAddress address = default(PlutusAddress), int bytes = default(int), ChoiceId choiceId = default(ChoiceId), ExBudget cost = default(ExBudget), string currencySymbol = default(string), string detail = default(string), string error = default(string), bool fatal = default(bool), string hash = default(string), string message = default(string), string roleName = default(string), Token token = default(Token), string tokenName = default(string), Transaction transaction = default(Transaction), string valueId = default(string), TransactionWarning warning = default(TransactionWarning))
        {
            // to ensure "detail" is required (not null)
            if (detail == null)
            {
                throw new ArgumentNullException("detail is a required property for SafetyError and cannot be null");
            }
            this.Detail = detail;
            // to ensure "error" is required (not null)
            if (error == null)
            {
                throw new ArgumentNullException("error is a required property for SafetyError and cannot be null");
            }
            this.Error = error;
            this.Fatal = fatal;
            this.AccountId = accountId;
            this.Address = address;
            this.Bytes = bytes;
            this.ChoiceId = choiceId;
            this.Cost = cost;
            this.CurrencySymbol = currencySymbol;
            this.Hash = hash;
            this.Message = message;
            this.RoleName = roleName;
            this.Token = token;
            this.TokenName = tokenName;
            this.Transaction = transaction;
            this.ValueId = valueId;
            this.Warning = warning;
        }

        /// <summary>
        /// Gets or Sets AccountId
        /// </summary>
        [DataMember(Name = "account-id", EmitDefaultValue = false)]
        public Party AccountId { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public PlutusAddress Address { get; set; }

        /// <summary>
        /// Gets or Sets Bytes
        /// </summary>
        [DataMember(Name = "bytes", EmitDefaultValue = false)]
        public int Bytes { get; set; }

        /// <summary>
        /// Gets or Sets ChoiceId
        /// </summary>
        [DataMember(Name = "choice-id", EmitDefaultValue = false)]
        public ChoiceId ChoiceId { get; set; }

        /// <summary>
        /// Gets or Sets Cost
        /// </summary>
        [DataMember(Name = "cost", EmitDefaultValue = false)]
        public ExBudget Cost { get; set; }

        /// <summary>
        /// Gets or Sets CurrencySymbol
        /// </summary>
        [DataMember(Name = "currency-symbol", EmitDefaultValue = false)]
        public string CurrencySymbol { get; set; }

        /// <summary>
        /// Gets or Sets Detail
        /// </summary>
        [DataMember(Name = "detail", IsRequired = true, EmitDefaultValue = true)]
        public string Detail { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", IsRequired = true, EmitDefaultValue = true)]
        public string Error { get; set; }

        /// <summary>
        /// Gets or Sets Fatal
        /// </summary>
        [DataMember(Name = "fatal", IsRequired = true, EmitDefaultValue = true)]
        public bool Fatal { get; set; }

        /// <summary>
        /// Gets or Sets Hash
        /// </summary>
        [DataMember(Name = "hash", EmitDefaultValue = false)]
        public string Hash { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets RoleName
        /// </summary>
        [DataMember(Name = "role-name", EmitDefaultValue = false)]
        public string RoleName { get; set; }

        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [DataMember(Name = "token", EmitDefaultValue = false)]
        public Token Token { get; set; }

        /// <summary>
        /// Gets or Sets TokenName
        /// </summary>
        [DataMember(Name = "token-name", EmitDefaultValue = false)]
        public string TokenName { get; set; }

        /// <summary>
        /// Gets or Sets Transaction
        /// </summary>
        [DataMember(Name = "transaction", EmitDefaultValue = false)]
        public Transaction Transaction { get; set; }

        /// <summary>
        /// Gets or Sets ValueId
        /// </summary>
        [DataMember(Name = "value-id", EmitDefaultValue = false)]
        public string ValueId { get; set; }

        /// <summary>
        /// Gets or Sets Warning
        /// </summary>
        [DataMember(Name = "warning", EmitDefaultValue = false)]
        public TransactionWarning Warning { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SafetyError {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Bytes: ").Append(Bytes).Append("\n");
            sb.Append("  ChoiceId: ").Append(ChoiceId).Append("\n");
            sb.Append("  Cost: ").Append(Cost).Append("\n");
            sb.Append("  CurrencySymbol: ").Append(CurrencySymbol).Append("\n");
            sb.Append("  Detail: ").Append(Detail).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Fatal: ").Append(Fatal).Append("\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  RoleName: ").Append(RoleName).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  TokenName: ").Append(TokenName).Append("\n");
            sb.Append("  Transaction: ").Append(Transaction).Append("\n");
            sb.Append("  ValueId: ").Append(ValueId).Append("\n");
            sb.Append("  Warning: ").Append(Warning).Append("\n");
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
            return this.Equals(input as SafetyError);
        }

        /// <summary>
        /// Returns true if SafetyError instances are equal
        /// </summary>
        /// <param name="input">Instance of SafetyError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SafetyError input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Bytes == input.Bytes ||
                    this.Bytes.Equals(input.Bytes)
                ) && 
                (
                    this.ChoiceId == input.ChoiceId ||
                    (this.ChoiceId != null &&
                    this.ChoiceId.Equals(input.ChoiceId))
                ) && 
                (
                    this.Cost == input.Cost ||
                    (this.Cost != null &&
                    this.Cost.Equals(input.Cost))
                ) && 
                (
                    this.CurrencySymbol == input.CurrencySymbol ||
                    (this.CurrencySymbol != null &&
                    this.CurrencySymbol.Equals(input.CurrencySymbol))
                ) && 
                (
                    this.Detail == input.Detail ||
                    (this.Detail != null &&
                    this.Detail.Equals(input.Detail))
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.Fatal == input.Fatal ||
                    this.Fatal.Equals(input.Fatal)
                ) && 
                (
                    this.Hash == input.Hash ||
                    (this.Hash != null &&
                    this.Hash.Equals(input.Hash))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.RoleName == input.RoleName ||
                    (this.RoleName != null &&
                    this.RoleName.Equals(input.RoleName))
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
                ) && 
                (
                    this.TokenName == input.TokenName ||
                    (this.TokenName != null &&
                    this.TokenName.Equals(input.TokenName))
                ) && 
                (
                    this.Transaction == input.Transaction ||
                    (this.Transaction != null &&
                    this.Transaction.Equals(input.Transaction))
                ) && 
                (
                    this.ValueId == input.ValueId ||
                    (this.ValueId != null &&
                    this.ValueId.Equals(input.ValueId))
                ) && 
                (
                    this.Warning == input.Warning ||
                    (this.Warning != null &&
                    this.Warning.Equals(input.Warning))
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
                if (this.AccountId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
                }
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Bytes.GetHashCode();
                if (this.ChoiceId != null)
                {
                    hashCode = (hashCode * 59) + this.ChoiceId.GetHashCode();
                }
                if (this.Cost != null)
                {
                    hashCode = (hashCode * 59) + this.Cost.GetHashCode();
                }
                if (this.CurrencySymbol != null)
                {
                    hashCode = (hashCode * 59) + this.CurrencySymbol.GetHashCode();
                }
                if (this.Detail != null)
                {
                    hashCode = (hashCode * 59) + this.Detail.GetHashCode();
                }
                if (this.Error != null)
                {
                    hashCode = (hashCode * 59) + this.Error.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Fatal.GetHashCode();
                if (this.Hash != null)
                {
                    hashCode = (hashCode * 59) + this.Hash.GetHashCode();
                }
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
                }
                if (this.RoleName != null)
                {
                    hashCode = (hashCode * 59) + this.RoleName.GetHashCode();
                }
                if (this.Token != null)
                {
                    hashCode = (hashCode * 59) + this.Token.GetHashCode();
                }
                if (this.TokenName != null)
                {
                    hashCode = (hashCode * 59) + this.TokenName.GetHashCode();
                }
                if (this.Transaction != null)
                {
                    hashCode = (hashCode * 59) + this.Transaction.GetHashCode();
                }
                if (this.ValueId != null)
                {
                    hashCode = (hashCode * 59) + this.ValueId.GetHashCode();
                }
                if (this.Warning != null)
                {
                    hashCode = (hashCode * 59) + this.Warning.GetHashCode();
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
            // Bytes (int) minimum
            if (this.Bytes < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Bytes, must be a value greater than or equal to 0.", new [] { "Bytes" });
            }

            yield break;
        }
    }

}
