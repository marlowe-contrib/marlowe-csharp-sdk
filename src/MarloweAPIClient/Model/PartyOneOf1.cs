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
    /// Refers to a party by Cardano address.
    /// </summary>
    [DataContract(Name = "Party_oneOf_1")]
    public partial class PartyOneOf1 : IEquatable<PartyOneOf1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PartyOneOf1" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PartyOneOf1() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PartyOneOf1" /> class.
        /// </summary>
        /// <param name="address">A cardano address (required).</param>
        public PartyOneOf1(string address = default(string))
        {
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new ArgumentNullException("address is a required property for PartyOneOf1 and cannot be null");
            }
            this._Address = address;
        }

        /// <summary>
        /// A cardano address
        /// </summary>
        /// <value>A cardano address</value>
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
            sb.Append("class PartyOneOf1 {\n");
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
            return this.Equals(input as PartyOneOf1);
        }

        /// <summary>
        /// Returns true if PartyOneOf1 instances are equal
        /// </summary>
        /// <param name="input">Instance of PartyOneOf1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PartyOneOf1 input)
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
