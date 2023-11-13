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
    /// Payout
    /// </summary>
    [DataContract(Name = "Payout")]
    public partial class Payout : IEquatable<Payout>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Payout" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Payout() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Payout" /> class.
        /// </summary>
        /// <param name="assets">assets (required).</param>
        /// <param name="payoutId">A reference to a transaction output with a transaction ID and index. (required).</param>
        /// <param name="role">role (required).</param>
        public Payout(Assets assets = default(Assets), string payoutId = default(string), string role = default(string))
        {
            // to ensure "assets" is required (not null)
            if (assets == null)
            {
                throw new ArgumentNullException("assets is a required property for Payout and cannot be null");
            }
            this._Assets = assets;
            // to ensure "payoutId" is required (not null)
            if (payoutId == null)
            {
                throw new ArgumentNullException("payoutId is a required property for Payout and cannot be null");
            }
            this._PayoutId = payoutId;
            // to ensure "role" is required (not null)
            if (role == null)
            {
                throw new ArgumentNullException("role is a required property for Payout and cannot be null");
            }
            this._Role = role;
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
        /// Gets or Sets Role
        /// </summary>
        [DataMember(Name = "role", IsRequired = true, EmitDefaultValue = true)]
        public string Role
        {
            get{ return _Role;}
            set
            {
                _Role = value;
                _flagRole = true;
            }
        }
        private string _Role;
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Payout {\n");
            sb.Append("  Assets: ").Append(Assets).Append("\n");
            sb.Append("  PayoutId: ").Append(PayoutId).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
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
            return this.Equals(input as Payout);
        }

        /// <summary>
        /// Returns true if Payout instances are equal
        /// </summary>
        /// <param name="input">Instance of Payout to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Payout input)
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
                    this.PayoutId == input.PayoutId ||
                    (this.PayoutId != null &&
                    this.PayoutId.Equals(input.PayoutId))
                ) && 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
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
                if (this.PayoutId != null)
                {
                    hashCode = (hashCode * 59) + this.PayoutId.GetHashCode();
                }
                if (this.Role != null)
                {
                    hashCode = (hashCode * 59) + this.Role.GetHashCode();
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
            if (this.PayoutId != null) {
                // PayoutId (string) pattern
                Regex regexPayoutId = new Regex(@"^[a-fA-F0-9]{64}#[0-9]+$", RegexOptions.CultureInvariant);
                if (!regexPayoutId.Match(this.PayoutId).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PayoutId, must match a pattern of " + regexPayoutId, new [] { "PayoutId" });
                }
            }

            yield break;
        }
    }

}
