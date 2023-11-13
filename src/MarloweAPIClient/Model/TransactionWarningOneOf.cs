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
    /// A warning for a non-positive deposit.
    /// </summary>
    [DataContract(Name = "TransactionWarning_oneOf")]
    public partial class TransactionWarningOneOf : IEquatable<TransactionWarningOneOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionWarningOneOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionWarningOneOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionWarningOneOf" /> class.
        /// </summary>
        /// <param name="askedToDeposit">askedToDeposit (required).</param>
        /// <param name="inAccount">inAccount (required).</param>
        /// <param name="ofToken">ofToken (required).</param>
        /// <param name="party">party (required).</param>
        public TransactionWarningOneOf(int askedToDeposit = default(int), Party inAccount = default(Party), Token ofToken = default(Token), Party party = default(Party))
        {
            this._AskedToDeposit = askedToDeposit;
            // to ensure "inAccount" is required (not null)
            if (inAccount == null)
            {
                throw new ArgumentNullException("inAccount is a required property for TransactionWarningOneOf and cannot be null");
            }
            this._InAccount = inAccount;
            // to ensure "ofToken" is required (not null)
            if (ofToken == null)
            {
                throw new ArgumentNullException("ofToken is a required property for TransactionWarningOneOf and cannot be null");
            }
            this._OfToken = ofToken;
            // to ensure "party" is required (not null)
            if (party == null)
            {
                throw new ArgumentNullException("party is a required property for TransactionWarningOneOf and cannot be null");
            }
            this._Party = party;
        }

        /// <summary>
        /// Gets or Sets AskedToDeposit
        /// </summary>
        [DataMember(Name = "asked_to_deposit", IsRequired = true, EmitDefaultValue = true)]
        public int AskedToDeposit
        {
            get{ return _AskedToDeposit;}
            set
            {
                _AskedToDeposit = value;
                _flagAskedToDeposit = true;
            }
        }
        private int _AskedToDeposit;
        private bool _flagAskedToDeposit;

        /// <summary>
        /// Returns false as AskedToDeposit should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAskedToDeposit()
        {
            return _flagAskedToDeposit;
        }
        /// <summary>
        /// Gets or Sets InAccount
        /// </summary>
        [DataMember(Name = "in_account", IsRequired = true, EmitDefaultValue = true)]
        public Party InAccount
        {
            get{ return _InAccount;}
            set
            {
                _InAccount = value;
                _flagInAccount = true;
            }
        }
        private Party _InAccount;
        private bool _flagInAccount;

        /// <summary>
        /// Returns false as InAccount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeInAccount()
        {
            return _flagInAccount;
        }
        /// <summary>
        /// Gets or Sets OfToken
        /// </summary>
        [DataMember(Name = "of_token", IsRequired = true, EmitDefaultValue = true)]
        public Token OfToken
        {
            get{ return _OfToken;}
            set
            {
                _OfToken = value;
                _flagOfToken = true;
            }
        }
        private Token _OfToken;
        private bool _flagOfToken;

        /// <summary>
        /// Returns false as OfToken should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeOfToken()
        {
            return _flagOfToken;
        }
        /// <summary>
        /// Gets or Sets Party
        /// </summary>
        [DataMember(Name = "party", IsRequired = true, EmitDefaultValue = true)]
        public Party Party
        {
            get{ return _Party;}
            set
            {
                _Party = value;
                _flagParty = true;
            }
        }
        private Party _Party;
        private bool _flagParty;

        /// <summary>
        /// Returns false as Party should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeParty()
        {
            return _flagParty;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransactionWarningOneOf {\n");
            sb.Append("  AskedToDeposit: ").Append(AskedToDeposit).Append("\n");
            sb.Append("  InAccount: ").Append(InAccount).Append("\n");
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
            return this.Equals(input as TransactionWarningOneOf);
        }

        /// <summary>
        /// Returns true if TransactionWarningOneOf instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionWarningOneOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionWarningOneOf input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AskedToDeposit == input.AskedToDeposit ||
                    this.AskedToDeposit.Equals(input.AskedToDeposit)
                ) && 
                (
                    this.InAccount == input.InAccount ||
                    (this.InAccount != null &&
                    this.InAccount.Equals(input.InAccount))
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
                hashCode = (hashCode * 59) + this.AskedToDeposit.GetHashCode();
                if (this.InAccount != null)
                {
                    hashCode = (hashCode * 59) + this.InAccount.GetHashCode();
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
