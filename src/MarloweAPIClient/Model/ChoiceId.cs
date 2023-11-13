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
    /// Refers to a party by role name.
    /// </summary>
    [DataContract(Name = "ChoiceId")]
    public partial class ChoiceId : IEquatable<ChoiceId>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChoiceId" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChoiceId() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChoiceId" /> class.
        /// </summary>
        /// <param name="choiceName">choiceName (required).</param>
        /// <param name="choiceOwner">choiceOwner (required).</param>
        public ChoiceId(string choiceName = default(string), Party choiceOwner = default(Party))
        {
            // to ensure "choiceName" is required (not null)
            if (choiceName == null)
            {
                throw new ArgumentNullException("choiceName is a required property for ChoiceId and cannot be null");
            }
            this._ChoiceName = choiceName;
            // to ensure "choiceOwner" is required (not null)
            if (choiceOwner == null)
            {
                throw new ArgumentNullException("choiceOwner is a required property for ChoiceId and cannot be null");
            }
            this._ChoiceOwner = choiceOwner;
        }

        /// <summary>
        /// Gets or Sets ChoiceName
        /// </summary>
        [DataMember(Name = "choice_name", IsRequired = true, EmitDefaultValue = true)]
        public string ChoiceName
        {
            get{ return _ChoiceName;}
            set
            {
                _ChoiceName = value;
                _flagChoiceName = true;
            }
        }
        private string _ChoiceName;
        private bool _flagChoiceName;

        /// <summary>
        /// Returns false as ChoiceName should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeChoiceName()
        {
            return _flagChoiceName;
        }
        /// <summary>
        /// Gets or Sets ChoiceOwner
        /// </summary>
        [DataMember(Name = "choice_owner", IsRequired = true, EmitDefaultValue = true)]
        public Party ChoiceOwner
        {
            get{ return _ChoiceOwner;}
            set
            {
                _ChoiceOwner = value;
                _flagChoiceOwner = true;
            }
        }
        private Party _ChoiceOwner;
        private bool _flagChoiceOwner;

        /// <summary>
        /// Returns false as ChoiceOwner should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeChoiceOwner()
        {
            return _flagChoiceOwner;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ChoiceId {\n");
            sb.Append("  ChoiceName: ").Append(ChoiceName).Append("\n");
            sb.Append("  ChoiceOwner: ").Append(ChoiceOwner).Append("\n");
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
            return this.Equals(input as ChoiceId);
        }

        /// <summary>
        /// Returns true if ChoiceId instances are equal
        /// </summary>
        /// <param name="input">Instance of ChoiceId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChoiceId input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ChoiceName == input.ChoiceName ||
                    (this.ChoiceName != null &&
                    this.ChoiceName.Equals(input.ChoiceName))
                ) && 
                (
                    this.ChoiceOwner == input.ChoiceOwner ||
                    (this.ChoiceOwner != null &&
                    this.ChoiceOwner.Equals(input.ChoiceOwner))
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
                if (this.ChoiceName != null)
                {
                    hashCode = (hashCode * 59) + this.ChoiceName.GetHashCode();
                }
                if (this.ChoiceOwner != null)
                {
                    hashCode = (hashCode * 59) + this.ChoiceOwner.GetHashCode();
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
