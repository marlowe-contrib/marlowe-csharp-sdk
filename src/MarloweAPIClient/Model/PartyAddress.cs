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
    /// Refers to a party by Cardano address.
    /// </summary>
    [DataContract(Name = "PartyAddress")]
    public partial class PartyAddress : IEquatable<PartyAddress>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PartyAddress" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PartyAddress() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PartyAddress" /> class.
        /// </summary>
        /// <param name="address">A cardano address, in Bech32 format (required).</param>
        public PartyAddress(string address = default(string))
        {
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new ArgumentNullException("address is a required property for PartyAddress and cannot be null");
            }
            this._Address = address;
        }

        /// <summary>
        /// A cardano address, in Bech32 format
        /// </summary>
        /// <value>A cardano address, in Bech32 format</value>
        /// <example>addr1w94f8ywk4fg672xasahtk4t9k6w3aql943uxz5rt62d4dvq8evxaf</example>
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = true)]
        public string Address
        {
            get{ return _Address;}
            set
            {
                _Address = value;
                _flagAddress = true;
            }
        }
        private string _Address;
        private bool _flagAddress;

        /// <summary>
        /// Returns false as Address should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAddress()
        {
            return _flagAddress;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PartyAddress {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
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
            return this.Equals(input as PartyAddress);
        }

        /// <summary>
        /// Returns true if PartyAddress instances are equal
        /// </summary>
        /// <param name="input">Instance of PartyAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PartyAddress input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
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
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
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