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
    /// ObservationOneOf1
    /// </summary>
    [DataContract(Name = "Observation_oneOf_1")]
    public partial class ObservationOneOf1 : IEquatable<ObservationOneOf1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObservationOneOf1" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ObservationOneOf1() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ObservationOneOf1" /> class.
        /// </summary>
        /// <param name="either">either (required).</param>
        /// <param name="or">or (required).</param>
        public ObservationOneOf1(Observation either = default(Observation), Observation or = default(Observation))
        {
            // to ensure "either" is required (not null)
            if (either == null)
            {
                throw new ArgumentNullException("either is a required property for ObservationOneOf1 and cannot be null");
            }
            this._Either = either;
            // to ensure "or" is required (not null)
            if (or == null)
            {
                throw new ArgumentNullException("or is a required property for ObservationOneOf1 and cannot be null");
            }
            this._Or = or;
        }

        /// <summary>
        /// Gets or Sets Either
        /// </summary>
        [DataMember(Name = "either", IsRequired = true, EmitDefaultValue = true)]
        public Observation Either
        {
            get{ return _Either;}
            set
            {
                _Either = value;
                _flagEither = true;
            }
        }
        private Observation _Either;
        private bool _flagEither;

        /// <summary>
        /// Returns false as Either should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEither()
        {
            return _flagEither;
        }
        /// <summary>
        /// Gets or Sets Or
        /// </summary>
        [DataMember(Name = "or", IsRequired = true, EmitDefaultValue = true)]
        public Observation Or
        {
            get{ return _Or;}
            set
            {
                _Or = value;
                _flagOr = true;
            }
        }
        private Observation _Or;
        private bool _flagOr;

        /// <summary>
        /// Returns false as Or should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeOr()
        {
            return _flagOr;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ObservationOneOf1 {\n");
            sb.Append("  Either: ").Append(Either).Append("\n");
            sb.Append("  Or: ").Append(Or).Append("\n");
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
            return this.Equals(input as ObservationOneOf1);
        }

        /// <summary>
        /// Returns true if ObservationOneOf1 instances are equal
        /// </summary>
        /// <param name="input">Instance of ObservationOneOf1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ObservationOneOf1 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Either == input.Either ||
                    (this.Either != null &&
                    this.Either.Equals(input.Either))
                ) && 
                (
                    this.Or == input.Or ||
                    (this.Or != null &&
                    this.Or.Equals(input.Or))
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
                if (this.Either != null)
                {
                    hashCode = (hashCode * 59) + this.Either.GetHashCode();
                }
                if (this.Or != null)
                {
                    hashCode = (hashCode * 59) + this.Or.GetHashCode();
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
