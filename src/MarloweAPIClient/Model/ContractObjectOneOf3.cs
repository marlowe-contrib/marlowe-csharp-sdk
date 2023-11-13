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
    /// Bind a value to a name within the scope of a sub-contract.
    /// </summary>
    [DataContract(Name = "ContractObject_oneOf_3")]
    public partial class ContractObjectOneOf3 : IEquatable<ContractObjectOneOf3>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContractObjectOneOf3" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContractObjectOneOf3() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContractObjectOneOf3" /> class.
        /// </summary>
        /// <param name="be">be (required).</param>
        /// <param name="let">let (required).</param>
        /// <param name="then">then (required).</param>
        public ContractObjectOneOf3(ValueObject be = default(ValueObject), string let = default(string), ContractObject then = default(ContractObject))
        {
            // to ensure "be" is required (not null)
            if (be == null)
            {
                throw new ArgumentNullException("be is a required property for ContractObjectOneOf3 and cannot be null");
            }
            this._Be = be;
            // to ensure "let" is required (not null)
            if (let == null)
            {
                throw new ArgumentNullException("let is a required property for ContractObjectOneOf3 and cannot be null");
            }
            this._Let = let;
            // to ensure "then" is required (not null)
            if (then == null)
            {
                throw new ArgumentNullException("then is a required property for ContractObjectOneOf3 and cannot be null");
            }
            this._Then = then;
        }

        /// <summary>
        /// Gets or Sets Be
        /// </summary>
        [DataMember(Name = "be", IsRequired = true, EmitDefaultValue = true)]
        public ValueObject Be
        {
            get{ return _Be;}
            set
            {
                _Be = value;
                _flagBe = true;
            }
        }
        private ValueObject _Be;
        private bool _flagBe;

        /// <summary>
        /// Returns false as Be should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeBe()
        {
            return _flagBe;
        }
        /// <summary>
        /// Gets or Sets Let
        /// </summary>
        [DataMember(Name = "let", IsRequired = true, EmitDefaultValue = true)]
        public string Let
        {
            get{ return _Let;}
            set
            {
                _Let = value;
                _flagLet = true;
            }
        }
        private string _Let;
        private bool _flagLet;

        /// <summary>
        /// Returns false as Let should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLet()
        {
            return _flagLet;
        }
        /// <summary>
        /// Gets or Sets Then
        /// </summary>
        [DataMember(Name = "then", IsRequired = true, EmitDefaultValue = true)]
        public ContractObject Then
        {
            get{ return _Then;}
            set
            {
                _Then = value;
                _flagThen = true;
            }
        }
        private ContractObject _Then;
        private bool _flagThen;

        /// <summary>
        /// Returns false as Then should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeThen()
        {
            return _flagThen;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ContractObjectOneOf3 {\n");
            sb.Append("  Be: ").Append(Be).Append("\n");
            sb.Append("  Let: ").Append(Let).Append("\n");
            sb.Append("  Then: ").Append(Then).Append("\n");
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
            return this.Equals(input as ContractObjectOneOf3);
        }

        /// <summary>
        /// Returns true if ContractObjectOneOf3 instances are equal
        /// </summary>
        /// <param name="input">Instance of ContractObjectOneOf3 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContractObjectOneOf3 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Be == input.Be ||
                    (this.Be != null &&
                    this.Be.Equals(input.Be))
                ) && 
                (
                    this.Let == input.Let ||
                    (this.Let != null &&
                    this.Let.Equals(input.Let))
                ) && 
                (
                    this.Then == input.Then ||
                    (this.Then != null &&
                    this.Then.Equals(input.Then))
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
                if (this.Be != null)
                {
                    hashCode = (hashCode * 59) + this.Be.GetHashCode();
                }
                if (this.Let != null)
                {
                    hashCode = (hashCode * 59) + this.Let.GetHashCode();
                }
                if (this.Then != null)
                {
                    hashCode = (hashCode * 59) + this.Then.GetHashCode();
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
