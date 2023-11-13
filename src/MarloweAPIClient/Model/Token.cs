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
    /// A token with a currency symbol (minting policy ID) and token name.
    /// </summary>
    [DataContract(Name = "Token")]
    public partial class Token : IEquatable<Token>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Token" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Token() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Token" /> class.
        /// </summary>
        /// <param name="currencySymbol">currencySymbol (required).</param>
        /// <param name="tokenName">tokenName (required).</param>
        public Token(string currencySymbol = default(string), string tokenName = default(string))
        {
            // to ensure "currencySymbol" is required (not null)
            if (currencySymbol == null)
            {
                throw new ArgumentNullException("currencySymbol is a required property for Token and cannot be null");
            }
            this._CurrencySymbol = currencySymbol;
            // to ensure "tokenName" is required (not null)
            if (tokenName == null)
            {
                throw new ArgumentNullException("tokenName is a required property for Token and cannot be null");
            }
            this._TokenName = tokenName;
        }

        /// <summary>
        /// Gets or Sets CurrencySymbol
        /// </summary>
        [DataMember(Name = "currency_symbol", IsRequired = true, EmitDefaultValue = true)]
        public string CurrencySymbol
        {
            get{ return _CurrencySymbol;}
            set
            {
                _CurrencySymbol = value;
                _flagCurrencySymbol = true;
            }
        }
        private string _CurrencySymbol;
        private bool _flagCurrencySymbol;

        /// <summary>
        /// Returns false as CurrencySymbol should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCurrencySymbol()
        {
            return _flagCurrencySymbol;
        }
        /// <summary>
        /// Gets or Sets TokenName
        /// </summary>
        [DataMember(Name = "token_name", IsRequired = true, EmitDefaultValue = true)]
        public string TokenName
        {
            get{ return _TokenName;}
            set
            {
                _TokenName = value;
                _flagTokenName = true;
            }
        }
        private string _TokenName;
        private bool _flagTokenName;

        /// <summary>
        /// Returns false as TokenName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTokenName()
        {
            return _flagTokenName;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Token {\n");
            sb.Append("  CurrencySymbol: ").Append(CurrencySymbol).Append("\n");
            sb.Append("  TokenName: ").Append(TokenName).Append("\n");
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
            return this.Equals(input as Token);
        }

        /// <summary>
        /// Returns true if Token instances are equal
        /// </summary>
        /// <param name="input">Instance of Token to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Token input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CurrencySymbol == input.CurrencySymbol ||
                    (this.CurrencySymbol != null &&
                    this.CurrencySymbol.Equals(input.CurrencySymbol))
                ) && 
                (
                    this.TokenName == input.TokenName ||
                    (this.TokenName != null &&
                    this.TokenName.Equals(input.TokenName))
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
                if (this.CurrencySymbol != null)
                {
                    hashCode = (hashCode * 59) + this.CurrencySymbol.GetHashCode();
                }
                if (this.TokenName != null)
                {
                    hashCode = (hashCode * 59) + this.TokenName.GetHashCode();
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
