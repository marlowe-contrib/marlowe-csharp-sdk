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
    /// A Marlowe payment.
    /// </summary>
    [DataContract(Name = "Payment")]
    public partial class Payment : IEquatable<Payment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Payment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Payment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Payment" /> class.
        /// </summary>
        /// <param name="amount">amount (required).</param>
        /// <param name="paymentFrom">paymentFrom (required).</param>
        /// <param name="to">to (required).</param>
        /// <param name="token">token (required).</param>
        public Payment(int amount = default(int), Party paymentFrom = default(Party), Payee to = default(Payee), Token token = default(Token))
        {
            this._Amount = amount;
            // to ensure "paymentFrom" is required (not null)
            if (paymentFrom == null)
            {
                throw new ArgumentNullException("paymentFrom is a required property for Payment and cannot be null");
            }
            this._PaymentFrom = paymentFrom;
            // to ensure "to" is required (not null)
            if (to == null)
            {
                throw new ArgumentNullException("to is a required property for Payment and cannot be null");
            }
            this._To = to;
            // to ensure "token" is required (not null)
            if (token == null)
            {
                throw new ArgumentNullException("token is a required property for Payment and cannot be null");
            }
            this._Token = token;
        }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = true)]
        public int Amount
        {
            get{ return _Amount;}
            set
            {
                _Amount = value;
                _flagAmount = true;
            }
        }
        private int _Amount;
        private bool _flagAmount;

        /// <summary>
        /// Returns false as Amount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAmount()
        {
            return _flagAmount;
        }
        /// <summary>
        /// Gets or Sets PaymentFrom
        /// </summary>
        [DataMember(Name = "payment_from", IsRequired = true, EmitDefaultValue = true)]
        public Party PaymentFrom
        {
            get{ return _PaymentFrom;}
            set
            {
                _PaymentFrom = value;
                _flagPaymentFrom = true;
            }
        }
        private Party _PaymentFrom;
        private bool _flagPaymentFrom;

        /// <summary>
        /// Returns false as PaymentFrom should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePaymentFrom()
        {
            return _flagPaymentFrom;
        }
        /// <summary>
        /// Gets or Sets To
        /// </summary>
        [DataMember(Name = "to", IsRequired = true, EmitDefaultValue = true)]
        public Payee To
        {
            get{ return _To;}
            set
            {
                _To = value;
                _flagTo = true;
            }
        }
        private Payee _To;
        private bool _flagTo;

        /// <summary>
        /// Returns false as To should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTo()
        {
            return _flagTo;
        }
        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [DataMember(Name = "token", IsRequired = true, EmitDefaultValue = true)]
        public Token Token
        {
            get{ return _Token;}
            set
            {
                _Token = value;
                _flagToken = true;
            }
        }
        private Token _Token;
        private bool _flagToken;

        /// <summary>
        /// Returns false as Token should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeToken()
        {
            return _flagToken;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Payment {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  PaymentFrom: ").Append(PaymentFrom).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
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
            return this.Equals(input as Payment);
        }

        /// <summary>
        /// Returns true if Payment instances are equal
        /// </summary>
        /// <param name="input">Instance of Payment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Payment input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.PaymentFrom == input.PaymentFrom ||
                    (this.PaymentFrom != null &&
                    this.PaymentFrom.Equals(input.PaymentFrom))
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
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
                hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                if (this.PaymentFrom != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentFrom.GetHashCode();
                }
                if (this.To != null)
                {
                    hashCode = (hashCode * 59) + this.To.GetHashCode();
                }
                if (this.Token != null)
                {
                    hashCode = (hashCode * 59) + this.Token.GetHashCode();
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
