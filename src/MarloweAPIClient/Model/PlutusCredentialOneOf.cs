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
    /// A Plutus public key credential.
    /// </summary>
    [DataContract(Name = "Plutus_Credential_oneOf")]
    public partial class PlutusCredentialOneOf : IEquatable<PlutusCredentialOneOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlutusCredentialOneOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PlutusCredentialOneOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PlutusCredentialOneOf" /> class.
        /// </summary>
        /// <param name="pubKeyCredential">pubKeyCredential (required).</param>
        public PlutusCredentialOneOf(string pubKeyCredential = default(string))
        {
            // to ensure "pubKeyCredential" is required (not null)
            if (pubKeyCredential == null)
            {
                throw new ArgumentNullException("pubKeyCredential is a required property for PlutusCredentialOneOf and cannot be null");
            }
            this._PubKeyCredential = pubKeyCredential;
        }

        /// <summary>
        /// Gets or Sets PubKeyCredential
        /// </summary>
        [DataMember(Name = "pubKeyCredential", IsRequired = true, EmitDefaultValue = true)]
        public string PubKeyCredential
        {
            get{ return _PubKeyCredential;}
            set
            {
                _PubKeyCredential = value;
                _flagPubKeyCredential = true;
            }
        }
        private string _PubKeyCredential;
        private bool _flagPubKeyCredential;

        /// <summary>
        /// Returns false as PubKeyCredential should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePubKeyCredential()
        {
            return _flagPubKeyCredential;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlutusCredentialOneOf {\n");
            sb.Append("  PubKeyCredential: ").Append(PubKeyCredential).Append("\n");
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
            return this.Equals(input as PlutusCredentialOneOf);
        }

        /// <summary>
        /// Returns true if PlutusCredentialOneOf instances are equal
        /// </summary>
        /// <param name="input">Instance of PlutusCredentialOneOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlutusCredentialOneOf input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PubKeyCredential == input.PubKeyCredential ||
                    (this.PubKeyCredential != null &&
                    this.PubKeyCredential.Equals(input.PubKeyCredential))
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
                if (this.PubKeyCredential != null)
                {
                    hashCode = (hashCode * 59) + this.PubKeyCredential.GetHashCode();
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
