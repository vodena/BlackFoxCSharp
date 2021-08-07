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
    /// Configuration for input column (feature)
    /// </summary>
    [DataContract]
    public partial class InputConfig :  IEquatable<InputConfig>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InputConfig" /> class.
        /// </summary>
        /// <param name="range">Min and max value for input.</param>
        /// <param name="encoding">Set encoding method for each input variable.</param>
        /// <param name="isOptional">Is input(feature) optional, used for feature selection (default to false).</param>
        public InputConfig(Range range = default(Range), List<Encoding> encoding = default(List<Encoding>), bool isOptional = false)
        {
            this.Range = range;
            this.Encoding = encoding;
            // use default value if no "isOptional" provided
            if (isOptional == null)
            {
                this.IsOptional = false;
            }
            else
            {
                this.IsOptional = isOptional;
            }
        }
        [JsonConstructorAttribute]
        protected InputConfig() { }
        /// <summary>
        /// Min and max value for input
        /// </summary>
        /// <value>Min and max value for input</value>
        [DataMember(Name="range", EmitDefaultValue=true)]
        public Range Range { get; set; }

        /// <summary>
        /// Set encoding method for each input variable
        /// </summary>
        /// <value>Set encoding method for each input variable</value>
        [DataMember(Name="encoding", EmitDefaultValue=true)]
        public List<Encoding> Encoding { get; set; }

        /// <summary>
        /// Is input(feature) optional, used for feature selection
        /// </summary>
        /// <value>Is input(feature) optional, used for feature selection</value>
        [DataMember(Name="isOptional", EmitDefaultValue=false)]
        public bool IsOptional { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InputConfig {\n");
            sb.Append("  Range: ").Append(Range).Append("\n");
            sb.Append("  Encoding: ").Append(Encoding).Append("\n");
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
                    this.Encoding == input.Encoding ||
                    this.Encoding != null &&
                    input.Encoding != null &&
                    this.Encoding.SequenceEqual(input.Encoding)
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
                if (this.Encoding != null)
                    hashCode = hashCode * 59 + this.Encoding.GetHashCode();
                if (this.IsOptional != null)
                    hashCode = hashCode * 59 + this.IsOptional.GetHashCode();
                return hashCode;
            }
        }
    }

}
