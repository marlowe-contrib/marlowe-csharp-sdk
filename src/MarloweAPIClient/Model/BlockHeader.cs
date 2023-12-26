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
    /// BlockHeader
    /// </summary>
    [DataContract(Name = "BlockHeader")]
    public partial class BlockHeader : IEquatable<BlockHeader>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BlockHeader" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BlockHeader() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BlockHeader" /> class.
        /// </summary>
        /// <param name="blockHeaderHash">blockHeaderHash (required).</param>
        /// <param name="blockNo">blockNo (required).</param>
        /// <param name="slotNo">slotNo (required).</param>
        public BlockHeader(string blockHeaderHash = default(string), long blockNo = default(long), long slotNo = default(long))
        {
            // to ensure "blockHeaderHash" is required (not null)
            if (blockHeaderHash == null)
            {
                throw new ArgumentNullException("blockHeaderHash is a required property for BlockHeader and cannot be null");
            }
            this._BlockHeaderHash = blockHeaderHash;
            this._BlockNo = blockNo;
            this._SlotNo = slotNo;
        }

        /// <summary>
        /// Gets or Sets BlockHeaderHash
        /// </summary>
        [DataMember(Name = "blockHeaderHash", IsRequired = true, EmitDefaultValue = true)]
        public string BlockHeaderHash
        {
            get{ return _BlockHeaderHash;}
            set
            {
                _BlockHeaderHash = value;
                _flagBlockHeaderHash = true;
            }
        }
        private string _BlockHeaderHash;
        private bool _flagBlockHeaderHash;

        /// <summary>
        /// Returns false as BlockHeaderHash should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeBlockHeaderHash()
        {
            return _flagBlockHeaderHash;
        }
        /// <summary>
        /// Gets or Sets BlockNo
        /// </summary>
        [DataMember(Name = "blockNo", IsRequired = true, EmitDefaultValue = true)]
        public long BlockNo
        {
            get{ return _BlockNo;}
            set
            {
                _BlockNo = value;
                _flagBlockNo = true;
            }
        }
        private long _BlockNo;
        private bool _flagBlockNo;

        /// <summary>
        /// Returns false as BlockNo should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeBlockNo()
        {
            return _flagBlockNo;
        }
        /// <summary>
        /// Gets or Sets SlotNo
        /// </summary>
        [DataMember(Name = "slotNo", IsRequired = true, EmitDefaultValue = true)]
        public long SlotNo
        {
            get{ return _SlotNo;}
            set
            {
                _SlotNo = value;
                _flagSlotNo = true;
            }
        }
        private long _SlotNo;
        private bool _flagSlotNo;

        /// <summary>
        /// Returns false as SlotNo should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSlotNo()
        {
            return _flagSlotNo;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BlockHeader {\n");
            sb.Append("  BlockHeaderHash: ").Append(BlockHeaderHash).Append("\n");
            sb.Append("  BlockNo: ").Append(BlockNo).Append("\n");
            sb.Append("  SlotNo: ").Append(SlotNo).Append("\n");
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
            return this.Equals(input as BlockHeader);
        }

        /// <summary>
        /// Returns true if BlockHeader instances are equal
        /// </summary>
        /// <param name="input">Instance of BlockHeader to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BlockHeader input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BlockHeaderHash == input.BlockHeaderHash ||
                    (this.BlockHeaderHash != null &&
                    this.BlockHeaderHash.Equals(input.BlockHeaderHash))
                ) && 
                (
                    this.BlockNo == input.BlockNo ||
                    this.BlockNo.Equals(input.BlockNo)
                ) && 
                (
                    this.SlotNo == input.SlotNo ||
                    this.SlotNo.Equals(input.SlotNo)
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
                if (this.BlockHeaderHash != null)
                {
                    hashCode = (hashCode * 59) + this.BlockHeaderHash.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.BlockNo.GetHashCode();
                hashCode = (hashCode * 59) + this.SlotNo.GetHashCode();
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
            // BlockNo (long) maximum
            if (this.BlockNo > (long)384)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BlockNo, must be a value less than or equal to 384.", new [] { "BlockNo" });
            }

            // BlockNo (long) minimum
            if (this.BlockNo < (long)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BlockNo, must be a value greater than or equal to 0.", new [] { "BlockNo" });
            }

            // SlotNo (long) maximum
            if (this.SlotNo > (long)384)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SlotNo, must be a value less than or equal to 384.", new [] { "SlotNo" });
            }

            // SlotNo (long) minimum
            if (this.SlotNo < (long)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SlotNo, must be a value greater than or equal to 0.", new [] { "SlotNo" });
            }

            yield break;
        }
    }

}
