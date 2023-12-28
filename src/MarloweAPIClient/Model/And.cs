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
    /// And
    /// </summary>
    [DataContract(Name = "And")]
    public partial class And : IEquatable<And>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="And" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected And() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="And" /> class.
        /// </summary>
        /// <param name="varAnd">varAnd (required).</param>
        /// <param name="both">both (required).</param>
        public And(Observation varAnd = default(Observation), Observation both = default(Observation))
        {
            // to ensure "varAnd" is required (not null)
            if (varAnd == null)
            {
                throw new ArgumentNullException("varAnd is a required property for And and cannot be null");
            }
            this._VarAnd = varAnd;
            // to ensure "both" is required (not null)
            if (both == null)
            {
                throw new ArgumentNullException("both is a required property for And and cannot be null");
            }
            this._Both = both;
        }

        /// <summary>
        /// Gets or Sets VarAnd
        /// </summary>
        [DataMember(Name = "and", IsRequired = true, EmitDefaultValue = true)]
        public Observation VarAnd
        {
            get{ return _VarAnd;}
            set
            {
                _VarAnd = value;
                _flagVarAnd = true;
            }
        }
        private Observation _VarAnd;
        private bool _flagVarAnd;

        /// <summary>
        /// Returns false as VarAnd should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeVarAnd()
        {
            return _flagVarAnd;
        }
        /// <summary>
        /// Gets or Sets Both
        /// </summary>
        [DataMember(Name = "both", IsRequired = true, EmitDefaultValue = true)]
        public Observation Both
        {
            get{ return _Both;}
            set
            {
                _Both = value;
                _flagBoth = true;
            }
        }
        private Observation _Both;
        private bool _flagBoth;

        /// <summary>
        /// Returns false as Both should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeBoth()
        {
            return _flagBoth;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class And {\n");
            sb.Append("  VarAnd: ").Append(VarAnd).Append("\n");
            sb.Append("  Both: ").Append(Both).Append("\n");
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
            return this.Equals(input as And);
        }

        /// <summary>
        /// Returns true if And instances are equal
        /// </summary>
        /// <param name="input">Instance of And to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(And input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.VarAnd == input.VarAnd ||
                    (this.VarAnd != null &&
                    this.VarAnd.Equals(input.VarAnd))
                ) && 
                (
                    this.Both == input.Both ||
                    (this.Both != null &&
                    this.Both.Equals(input.Both))
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
                if (this.VarAnd != null)
                {
                    hashCode = (hashCode * 59) + this.VarAnd.GetHashCode();
                }
                if (this.Both != null)
                {
                    hashCode = (hashCode * 59) + this.Both.GetHashCode();
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