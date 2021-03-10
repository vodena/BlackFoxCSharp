/* 
 * BlackFox
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenAPIDateConverter = BlackFoxCSharp.Client.OpenAPIDateConverter;

namespace BlackFoxCSharp.Model
{
    /// <summary>
    /// RangeInt
    /// </summary>
    [DataContract]
    public partial class RangeInt :  IEquatable<RangeInt>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RangeInt" /> class.
        /// </summary>
        /// <param name="min">min.</param>
        /// <param name="max">max.</param>
        public RangeInt(int min = default(int), int max = default(int))
        {
            this.Min = min;
            this.Max = max;
        }
        [JsonConstructorAttribute]
        protected RangeInt() { }
        /// <summary>
        /// Gets or Sets Min
        /// </summary>
        [DataMember(Name="min", EmitDefaultValue=false)]
        public int Min { get; set; }

        /// <summary>
        /// Gets or Sets Max
        /// </summary>
        [DataMember(Name="max", EmitDefaultValue=false)]
        public int Max { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RangeInt {\n");
            sb.Append("  Min: ").Append(Min).Append("\n");
            sb.Append("  Max: ").Append(Max).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as RangeInt);
        }

        /// <summary>
        /// Returns true if RangeInt instances are equal
        /// </summary>
        /// <param name="input">Instance of RangeInt to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RangeInt input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Min == input.Min ||
                    (this.Min != null &&
                    this.Min.Equals(input.Min))
                ) && 
                (
                    this.Max == input.Max ||
                    (this.Max != null &&
                    this.Max.Equals(input.Max))
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
                if (this.Min != null)
                    hashCode = hashCode * 59 + this.Min.GetHashCode();
                if (this.Max != null)
                    hashCode = hashCode * 59 + this.Max.GetHashCode();
                return hashCode;
            }
        }
    }

}
