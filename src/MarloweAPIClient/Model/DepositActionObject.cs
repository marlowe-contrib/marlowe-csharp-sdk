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
    /// DepositActionObject
    /// </summary>
    [DataContract(Name = "DepositActionObject")]
    public partial class DepositActionObject : IEquatable<DepositActionObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DepositActionObject" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DepositActionObject() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DepositActionObject" /> class.
        /// </summary>
        /// <param name="deposits">deposits (required).</param>
        /// <param name="intoAccount">intoAccount (required).</param>
        /// <param name="ofToken">ofToken (required).</param>
        /// <param name="party">party (required).</param>
        public DepositActionObject(Value deposits = default(Value), Party intoAccount = default(Party), Token ofToken = default(Token), Party party = default(Party))
        {
            // to ensure "deposits" is required (not null)
            if (deposits == null)
            {
                throw new ArgumentNullException("deposits is a required property for DepositActionObject and cannot be null");
            }
            this.Deposits = deposits;
            // to ensure "intoAccount" is required (not null)
            if (intoAccount == null)
            {
                throw new ArgumentNullException("intoAccount is a required property for DepositActionObject and cannot be null");
            }
            this.IntoAccount = intoAccount;
            // to ensure "ofToken" is required (not null)
            if (ofToken == null)
            {
                throw new ArgumentNullException("ofToken is a required property for DepositActionObject and cannot be null");
            }
            this.OfToken = ofToken;
            // to ensure "party" is required (not null)
            if (party == null)
            {
                throw new ArgumentNullException("party is a required property for DepositActionObject and cannot be null");
            }
            this.Party = party;
        }

        /// <summary>
        /// Gets or Sets Deposits
        /// </summary>
        [DataMember(Name = "deposits", IsRequired = true, EmitDefaultValue = true)]
        public Value Deposits { get; set; }

        /// <summary>
        /// Gets or Sets IntoAccount
        /// </summary>
        [DataMember(Name = "into_account", IsRequired = true, EmitDefaultValue = true)]
        public Party IntoAccount { get; set; }

        /// <summary>
        /// Gets or Sets OfToken
        /// </summary>
        [DataMember(Name = "of_token", IsRequired = true, EmitDefaultValue = true)]
        public Token OfToken { get; set; }

        /// <summary>
        /// Gets or Sets Party
        /// </summary>
        [DataMember(Name = "party", IsRequired = true, EmitDefaultValue = true)]
        public Party Party { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DepositActionObject {\n");
            sb.Append("  Deposits: ").Append(Deposits).Append("\n");
            sb.Append("  IntoAccount: ").Append(IntoAccount).Append("\n");
            sb.Append("  OfToken: ").Append(OfToken).Append("\n");
            sb.Append("  Party: ").Append(Party).Append("\n");
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
            return this.Equals(input as DepositActionObject);
        }

        /// <summary>
        /// Returns true if DepositActionObject instances are equal
        /// </summary>
        /// <param name="input">Instance of DepositActionObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DepositActionObject input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Deposits == input.Deposits ||
                    (this.Deposits != null &&
                    this.Deposits.Equals(input.Deposits))
                ) && 
                (
                    this.IntoAccount == input.IntoAccount ||
                    (this.IntoAccount != null &&
                    this.IntoAccount.Equals(input.IntoAccount))
                ) && 
                (
                    this.OfToken == input.OfToken ||
                    (this.OfToken != null &&
                    this.OfToken.Equals(input.OfToken))
                ) && 
                (
                    this.Party == input.Party ||
                    (this.Party != null &&
                    this.Party.Equals(input.Party))
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
                if (this.Deposits != null)
                {
                    hashCode = (hashCode * 59) + this.Deposits.GetHashCode();
                }
                if (this.IntoAccount != null)
                {
                    hashCode = (hashCode * 59) + this.IntoAccount.GetHashCode();
                }
                if (this.OfToken != null)
                {
                    hashCode = (hashCode * 59) + this.OfToken.GetHashCode();
                }
                if (this.Party != null)
                {
                    hashCode = (hashCode * 59) + this.Party.GetHashCode();
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
