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
    /// GetContractResponseLinks
    /// </summary>
    [DataContract(Name = "GetContractResponse_links")]
    public partial class GetContractResponseLinks : IEquatable<GetContractResponseLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetContractResponseLinks" /> class.
        /// </summary>
        /// <param name="transactions">transactions.</param>
        public GetContractResponseLinks(string transactions = default(string))
        {
            this._Transactions = transactions;
            if (this.Transactions != null)
            {
                this._flagTransactions = true;
            }
        }

        /// <summary>
        /// Gets or Sets Transactions
        /// </summary>
        [DataMember(Name = "transactions", EmitDefaultValue = false)]
        public string Transactions
        {
            get{ return _Transactions;}
            set
            {
                _Transactions = value;
                _flagTransactions = true;
            }
        }
        private string _Transactions;
        private bool _flagTransactions;

        /// <summary>
        /// Returns false as Transactions should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTransactions()
        {
            return _flagTransactions;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetContractResponseLinks {\n");
            sb.Append("  Transactions: ").Append(Transactions).Append("\n");
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
            return this.Equals(input as GetContractResponseLinks);
        }

        /// <summary>
        /// Returns true if GetContractResponseLinks instances are equal
        /// </summary>
        /// <param name="input">Instance of GetContractResponseLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetContractResponseLinks input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Transactions == input.Transactions ||
                    (this.Transactions != null &&
                    this.Transactions.Equals(input.Transactions))
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
                if (this.Transactions != null)
                {
                    hashCode = (hashCode * 59) + this.Transactions.GetHashCode();
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