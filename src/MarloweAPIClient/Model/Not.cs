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
    /// Not
    /// </summary>
    [DataContract(Name = "Not")]
    public partial class Not : IEquatable<Not>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Not" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Not() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Not" /> class.
        /// </summary>
        /// <param name="varNot">varNot (required).</param>
        public Not(Observation varNot = default(Observation))
        {
            // to ensure "varNot" is required (not null)
            if (varNot == null)
            {
                throw new ArgumentNullException("varNot is a required property for Not and cannot be null");
            }
            this._VarNot = varNot;
        }

        /// <summary>
        /// Gets or Sets VarNot
        /// </summary>
        [DataMember(Name = "not", IsRequired = true, EmitDefaultValue = true)]
        public Observation VarNot
        {
            get{ return _VarNot;}
            set
            {
                _VarNot = value;
                _flagVarNot = true;
            }
        }
        private Observation _VarNot;
        private bool _flagVarNot;

        /// <summary>
        /// Returns false as VarNot should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeVarNot()
        {
            return _flagVarNot;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Not {\n");
            sb.Append("  VarNot: ").Append(VarNot).Append("\n");
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
            return this.Equals(input as Not);
        }

        /// <summary>
        /// Returns true if Not instances are equal
        /// </summary>
        /// <param name="input">Instance of Not to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Not input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.VarNot == input.VarNot ||
                    (this.VarNot != null &&
                    this.VarNot.Equals(input.VarNot))
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
                if (this.VarNot != null)
                {
                    hashCode = (hashCode * 59) + this.VarNot.GetHashCode();
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