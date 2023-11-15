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
    /// CaseObjectOneOf
    /// </summary>
    [DataContract(Name = "CaseObject_oneOf")]
    public partial class CaseObjectOneOf : IEquatable<CaseObjectOneOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CaseObjectOneOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CaseObjectOneOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CaseObjectOneOf" /> class.
        /// </summary>
        /// <param name="varCase">varCase (required).</param>
        /// <param name="then">then (required).</param>
        public CaseObjectOneOf(ActionObject varCase = default(ActionObject), ContractObject then = default(ContractObject))
        {
            // to ensure "varCase" is required (not null)
            if (varCase == null)
            {
                throw new ArgumentNullException("varCase is a required property for CaseObjectOneOf and cannot be null");
            }
            this._VarCase = varCase;
            // to ensure "then" is required (not null)
            if (then == null)
            {
                throw new ArgumentNullException("then is a required property for CaseObjectOneOf and cannot be null");
            }
            this._Then = then;
        }

        /// <summary>
        /// Gets or Sets VarCase
        /// </summary>
        [DataMember(Name = "case", IsRequired = true, EmitDefaultValue = true)]
        public ActionObject VarCase
        {
            get{ return _VarCase;}
            set
            {
                _VarCase = value;
                _flagVarCase = true;
            }
        }
        private ActionObject _VarCase;
        private bool _flagVarCase;

        /// <summary>
        /// Returns false as VarCase should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeVarCase()
        {
            return _flagVarCase;
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
            sb.Append("class CaseObjectOneOf {\n");
            sb.Append("  VarCase: ").Append(VarCase).Append("\n");
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
            return this.Equals(input as CaseObjectOneOf);
        }

        /// <summary>
        /// Returns true if CaseObjectOneOf instances are equal
        /// </summary>
        /// <param name="input">Instance of CaseObjectOneOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CaseObjectOneOf input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.VarCase == input.VarCase ||
                    (this.VarCase != null &&
                    this.VarCase.Equals(input.VarCase))
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
                if (this.VarCase != null)
                {
                    hashCode = (hashCode * 59) + this.VarCase.GetHashCode();
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
