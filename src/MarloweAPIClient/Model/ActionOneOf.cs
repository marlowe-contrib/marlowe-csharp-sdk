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
    /// ActionOneOf
    /// </summary>
    [DataContract(Name = "Action_oneOf")]
    public partial class ActionOneOf : IEquatable<ActionOneOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionOneOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ActionOneOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionOneOf" /> class.
        /// </summary>
        /// <param name="deposits">deposits (required).</param>
        /// <param name="intoAccount">intoAccount (required).</param>
        /// <param name="ofToken">ofToken (required).</param>
        /// <param name="party">party (required).</param>
        public ActionOneOf(Value deposits = default(Value), Party intoAccount = default(Party), Token ofToken = default(Token), Party party = default(Party))
        {
            // to ensure "deposits" is required (not null)
            if (deposits == null)
            {
                throw new ArgumentNullException("deposits is a required property for ActionOneOf and cannot be null");
            }
            this._Deposits = deposits;
            // to ensure "intoAccount" is required (not null)
            if (intoAccount == null)
            {
                throw new ArgumentNullException("intoAccount is a required property for ActionOneOf and cannot be null");
            }
            this._IntoAccount = intoAccount;
            // to ensure "ofToken" is required (not null)
            if (ofToken == null)
            {
                throw new ArgumentNullException("ofToken is a required property for ActionOneOf and cannot be null");
            }
            this._OfToken = ofToken;
            // to ensure "party" is required (not null)
            if (party == null)
            {
                throw new ArgumentNullException("party is a required property for ActionOneOf and cannot be null");
            }
            this._Party = party;
        }

        /// <summary>
        /// Gets or Sets Deposits
        /// </summary>
        [DataMember(Name = "deposits", IsRequired = true, EmitDefaultValue = true)]
        public Value Deposits
        {
            get{ return _Deposits;}
            set
            {
                _Deposits = value;
                _flagDeposits = true;
            }
        }
        private Value _Deposits;
        private bool _flagDeposits;

        /// <summary>
        /// Returns false as Deposits should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDeposits()
        {
            return _flagDeposits;
        }
        /// <summary>
        /// Gets or Sets IntoAccount
        /// </summary>
        [DataMember(Name = "into_account", IsRequired = true, EmitDefaultValue = true)]
        public Party IntoAccount
        {
            get{ return _IntoAccount;}
            set
            {
                _IntoAccount = value;
                _flagIntoAccount = true;
            }
        }
        private Party _IntoAccount;
        private bool _flagIntoAccount;

        /// <summary>
        /// Returns false as IntoAccount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeIntoAccount()
        {
            return _flagIntoAccount;
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
            sb.Append("class ActionOneOf {\n");
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
            return this.Equals(input as ActionOneOf);
        }

        /// <summary>
        /// Returns true if ActionOneOf instances are equal
        /// </summary>
        /// <param name="input">Instance of ActionOneOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActionOneOf input)
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
