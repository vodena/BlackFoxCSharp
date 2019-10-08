/* 
 * BlackFox
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = BlackFoxCSharp.Client.SwaggerDateConverter;

namespace BlackFoxCSharp.Model
{
    /// <summary>
    /// Configuration for input column (feature)
    /// </summary>
    [DataContract]
    public partial class InputConfig :  IEquatable<InputConfig>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InputConfig" /> class.
        /// </summary>
        /// <param name="range">Min and max value for input.</param>
        /// <param name="isOptional">Is input(feature) optional, used for feature selection.</param>
        public InputConfig(Range range = default(Range), bool? isOptional = default(bool?))
        {
            this.Range = range;
            this.IsOptional = isOptional;
        }
        
        /// <summary>
        /// Min and max value for input
        /// </summary>
        /// <value>Min and max value for input</value>
        [DataMember(Name="range", EmitDefaultValue=false)]
        public Range Range { get; set; }

        /// <summary>
        /// Is input(feature) optional, used for feature selection
        /// </summary>
        /// <value>Is input(feature) optional, used for feature selection</value>
        [DataMember(Name="isOptional", EmitDefaultValue=false)]
        public bool? IsOptional { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InputConfig {\n");
            sb.Append("  Range: ").Append(Range).Append("\n");
            sb.Append("  IsOptional: ").Append(IsOptional).Append("\n");
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
            return this.Equals(input as InputConfig);
        }

        /// <summary>
        /// Returns true if InputConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of InputConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InputConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Range == input.Range ||
                    (this.Range != null &&
                    this.Range.Equals(input.Range))
                ) && 
                (
                    this.IsOptional == input.IsOptional ||
                    (this.IsOptional != null &&
                    this.IsOptional.Equals(input.IsOptional))
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
                if (this.Range != null)
                    hashCode = hashCode * 59 + this.Range.GetHashCode();
                if (this.IsOptional != null)
                    hashCode = hashCode * 59 + this.IsOptional.GetHashCode();
                return hashCode;
            }
        }
    }

}
