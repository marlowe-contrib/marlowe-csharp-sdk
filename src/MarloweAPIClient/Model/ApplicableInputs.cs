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
    /// Applicable Inputs for a given contract
    /// </summary>
    [DataContract(Name = "ApplicableInputs")]
    public partial class ApplicableInputs : IEquatable<ApplicableInputs>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicableInputs" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ApplicableInputs() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicableInputs" /> class.
        /// </summary>
        /// <param name="choices">choices (required).</param>
        /// <param name="deposits">deposits (required).</param>
        /// <param name="notify">notify.</param>
        public ApplicableInputs(List<CanChoose> choices = default(List<CanChoose>), List<CanDeposit> deposits = default(List<CanDeposit>), CanNotify notify = default(CanNotify))
        {
            // to ensure "choices" is required (not null)
            if (choices == null)
            {
                throw new ArgumentNullException("choices is a required property for ApplicableInputs and cannot be null");
            }
            this._Choices = choices;
            // to ensure "deposits" is required (not null)
            if (deposits == null)
            {
                throw new ArgumentNullException("deposits is a required property for ApplicableInputs and cannot be null");
            }
            this._Deposits = deposits;
            this._Notify = notify;
            if (this.Notify != null)
            {
                this._flagNotify = true;
            }
        }

        /// <summary>
        /// Gets or Sets Choices
        /// </summary>
        [DataMember(Name = "choices", IsRequired = true, EmitDefaultValue = true)]
        public List<CanChoose> Choices
        {
            get{ return _Choices;}
            set
            {
                _Choices = value;
                _flagChoices = true;
            }
        }
        private List<CanChoose> _Choices;
        private bool _flagChoices;

        /// <summary>
        /// Returns false as Choices should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeChoices()
        {
            return _flagChoices;
        }
        /// <summary>
        /// Gets or Sets Deposits
        /// </summary>
        [DataMember(Name = "deposits", IsRequired = true, EmitDefaultValue = true)]
        public List<CanDeposit> Deposits
        {
            get{ return _Deposits;}
            set
            {
                _Deposits = value;
                _flagDeposits = true;
            }
        }
        private List<CanDeposit> _Deposits;
        private bool _flagDeposits;

        /// <summary>
        /// Returns false as Deposits should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDeposits()
        {
            return _flagDeposits;
        }
        /// <summary>
        /// Gets or Sets Notify
        /// </summary>
        [DataMember(Name = "notify", EmitDefaultValue = false)]
        public CanNotify Notify
        {
            get{ return _Notify;}
            set
            {
                _Notify = value;
                _flagNotify = true;
            }
        }
        private CanNotify _Notify;
        private bool _flagNotify;

        /// <summary>
        /// Returns false as Notify should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeNotify()
        {
            return _flagNotify;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApplicableInputs {\n");
            sb.Append("  Choices: ").Append(Choices).Append("\n");
            sb.Append("  Deposits: ").Append(Deposits).Append("\n");
            sb.Append("  Notify: ").Append(Notify).Append("\n");
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
            return this.Equals(input as ApplicableInputs);
        }

        /// <summary>
        /// Returns true if ApplicableInputs instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicableInputs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicableInputs input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Choices == input.Choices ||
                    this.Choices != null &&
                    input.Choices != null &&
                    this.Choices.SequenceEqual(input.Choices)
                ) && 
                (
                    this.Deposits == input.Deposits ||
                    this.Deposits != null &&
                    input.Deposits != null &&
                    this.Deposits.SequenceEqual(input.Deposits)
                ) && 
                (
                    this.Notify == input.Notify ||
                    (this.Notify != null &&
                    this.Notify.Equals(input.Notify))
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
                if (this.Choices != null)
                {
                    hashCode = (hashCode * 59) + this.Choices.GetHashCode();
                }
                if (this.Deposits != null)
                {
                    hashCode = (hashCode * 59) + this.Deposits.GetHashCode();
                }
                if (this.Notify != null)
                {
                    hashCode = (hashCode * 59) + this.Notify.GetHashCode();
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
