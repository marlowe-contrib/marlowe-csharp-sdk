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
    /// ObservationObjectOneOf2
    /// </summary>
    [DataContract(Name = "ObservationObject_oneOf_2")]
    public partial class ObservationObjectOneOf2 : IEquatable<ObservationObjectOneOf2>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObservationObjectOneOf2" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ObservationObjectOneOf2() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ObservationObjectOneOf2" /> class.
        /// </summary>
        /// <param name="not">not (required).</param>
        public ObservationObjectOneOf2(ObservationObject not = default(ObservationObject))
        {
            // to ensure "not" is required (not null)
            if (not == null)
            {
                throw new ArgumentNullException("not is a required property for ObservationObjectOneOf2 and cannot be null");
            }
            this._Not = not;
        }

        /// <summary>
        /// Gets or Sets Not
        /// </summary>
        [DataMember(Name = "not", IsRequired = true, EmitDefaultValue = true)]
        public ObservationObject Not
        {
            get{ return _Not;}
            set
            {
                _Not = value;
                _flagNot = true;
            }
        }
        private ObservationObject _Not;
        private bool _flagNot;

        /// <summary>
        /// Returns false as Not should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeNot()
        {
            return _flagNot;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ObservationObjectOneOf2 {\n");
            sb.Append("  Not: ").Append(Not).Append("\n");
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
            return this.Equals(input as ObservationObjectOneOf2);
        }

        /// <summary>
        /// Returns true if ObservationObjectOneOf2 instances are equal
        /// </summary>
        /// <param name="input">Instance of ObservationObjectOneOf2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ObservationObjectOneOf2 input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Not == input.Not ||
                    (this.Not != null &&
                    this.Not.Equals(input.Not))
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
                if (this.Not != null)
                {
                    hashCode = (hashCode * 59) + this.Not.GetHashCode();
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
