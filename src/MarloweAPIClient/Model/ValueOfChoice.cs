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
    /// ValueOfChoice
    /// </summary>
    [DataContract(Name = "ValueOfChoice")]
    public partial class ValueOfChoice : IEquatable<ValueOfChoice>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValueOfChoice" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ValueOfChoice() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ValueOfChoice" /> class.
        /// </summary>
        /// <param name="varValueOfChoice">varValueOfChoice (required).</param>
        public ValueOfChoice(ChoiceId varValueOfChoice = default(ChoiceId))
        {
            // to ensure "varValueOfChoice" is required (not null)
            if (varValueOfChoice == null)
            {
                throw new ArgumentNullException("varValueOfChoice is a required property for ValueOfChoice and cannot be null");
            }
            this.VarValueOfChoice = varValueOfChoice;
        }

        /// <summary>
        /// Gets or Sets VarValueOfChoice
        /// </summary>
        [DataMember(Name = "value_of_choice", IsRequired = true, EmitDefaultValue = true)]
        public ChoiceId VarValueOfChoice { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ValueOfChoice {\n");
            sb.Append("  VarValueOfChoice: ").Append(VarValueOfChoice).Append("\n");
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
            return this.Equals(input as ValueOfChoice);
        }

        /// <summary>
        /// Returns true if ValueOfChoice instances are equal
        /// </summary>
        /// <param name="input">Instance of ValueOfChoice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValueOfChoice input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.VarValueOfChoice == input.VarValueOfChoice ||
                    (this.VarValueOfChoice != null &&
                    this.VarValueOfChoice.Equals(input.VarValueOfChoice))
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
                if (this.VarValueOfChoice != null)
                {
                    hashCode = (hashCode * 59) + this.VarValueOfChoice.GetHashCode();
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
