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
    /// Series input column configuration
    /// </summary>
    [DataContract]
    public partial class InputWindowConfig :  IEquatable<InputWindowConfig>
    {
        /// <summary>
        /// Aggregation type for values
        /// </summary>
        /// <value>Aggregation type for values</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AggregationTypeEnum
        {
            
            /// <summary>
            /// Enum Avg for value: Avg
            /// </summary>
            [EnumMember(Value = "Avg")]
            Avg = 1,
            
            /// <summary>
            /// Enum Sum for value: Sum
            /// </summary>
            [EnumMember(Value = "Sum")]
            Sum = 2,
            
            /// <summary>
            /// Enum None for value: None
            /// </summary>
            [EnumMember(Value = "None")]
            None = 3
        }

        /// <summary>
        /// Aggregation type for values
        /// </summary>
        /// <value>Aggregation type for values</value>
        [DataMember(Name="aggregationType", EmitDefaultValue=false)]
        public AggregationTypeEnum? AggregationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InputWindowConfig" /> class.
        /// </summary>
        /// <param name="step">Number od values to skip before taking next value.</param>
        /// <param name="aggregationType">Aggregation type for values.</param>
        /// <param name="window">Window width, number od values to take.</param>
        /// <param name="shift">Number of values to skip before taking value.  The negative value skips the data to the left, the positive skips the data to the right..</param>
        public InputWindowConfig(int? step = default(int?), AggregationTypeEnum? aggregationType = default(AggregationTypeEnum?), int? window = default(int?), int? shift = default(int?))
        {
            this.Step = step;
            this.AggregationType = aggregationType;
            this.Window = window;
            this.Shift = shift;
        }
        
        /// <summary>
        /// Number od values to skip before taking next value
        /// </summary>
        /// <value>Number od values to skip before taking next value</value>
        [DataMember(Name="step", EmitDefaultValue=false)]
        public int? Step { get; set; }


        /// <summary>
        /// Window width, number od values to take
        /// </summary>
        /// <value>Window width, number od values to take</value>
        [DataMember(Name="window", EmitDefaultValue=false)]
        public int? Window { get; set; }

        /// <summary>
        /// Number of values to skip before taking value.  The negative value skips the data to the left, the positive skips the data to the right.
        /// </summary>
        /// <value>Number of values to skip before taking value.  The negative value skips the data to the left, the positive skips the data to the right.</value>
        [DataMember(Name="shift", EmitDefaultValue=false)]
        public int? Shift { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InputWindowConfig {\n");
            sb.Append("  Step: ").Append(Step).Append("\n");
            sb.Append("  AggregationType: ").Append(AggregationType).Append("\n");
            sb.Append("  Window: ").Append(Window).Append("\n");
            sb.Append("  Shift: ").Append(Shift).Append("\n");
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
            return this.Equals(input as InputWindowConfig);
        }

        /// <summary>
        /// Returns true if InputWindowConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of InputWindowConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InputWindowConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Step == input.Step ||
                    (this.Step != null &&
                    this.Step.Equals(input.Step))
                ) && 
                (
                    this.AggregationType == input.AggregationType ||
                    (this.AggregationType != null &&
                    this.AggregationType.Equals(input.AggregationType))
                ) && 
                (
                    this.Window == input.Window ||
                    (this.Window != null &&
                    this.Window.Equals(input.Window))
                ) && 
                (
                    this.Shift == input.Shift ||
                    (this.Shift != null &&
                    this.Shift.Equals(input.Shift))
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
                if (this.Step != null)
                    hashCode = hashCode * 59 + this.Step.GetHashCode();
                if (this.AggregationType != null)
                    hashCode = hashCode * 59 + this.AggregationType.GetHashCode();
                if (this.Window != null)
                    hashCode = hashCode * 59 + this.Window.GetHashCode();
                if (this.Shift != null)
                    hashCode = hashCode * 59 + this.Shift.GetHashCode();
                return hashCode;
            }
        }
    }

}