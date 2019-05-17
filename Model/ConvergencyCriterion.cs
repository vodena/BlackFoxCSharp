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
    /// ConvergencyCriterion
    /// </summary>
    [DataContract]
    public partial class ConvergencyCriterion :  IEquatable<ConvergencyCriterion>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConvergencyCriterion" /> class.
        /// </summary>
        /// <param name="numberOfLatestGenerations">numberOfLatestGenerations.</param>
        /// <param name="percentageOfTolerance">percentageOfTolerance.</param>
        public ConvergencyCriterion(int? numberOfLatestGenerations = default(int?), double? percentageOfTolerance = default(double?))
        {
            this.NumberOfLatestGenerations = numberOfLatestGenerations;
            this.PercentageOfTolerance = percentageOfTolerance;
        }
        
        /// <summary>
        /// Gets or Sets NumberOfLatestGenerations
        /// </summary>
        [DataMember(Name="numberOfLatestGenerations", EmitDefaultValue=false)]
        public int? NumberOfLatestGenerations { get; set; }

        /// <summary>
        /// Gets or Sets PercentageOfTolerance
        /// </summary>
        [DataMember(Name="percentageOfTolerance", EmitDefaultValue=false)]
        public double? PercentageOfTolerance { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConvergencyCriterion {\n");
            sb.Append("  NumberOfLatestGenerations: ").Append(NumberOfLatestGenerations).Append("\n");
            sb.Append("  PercentageOfTolerance: ").Append(PercentageOfTolerance).Append("\n");
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
            return this.Equals(input as ConvergencyCriterion);
        }

        /// <summary>
        /// Returns true if ConvergencyCriterion instances are equal
        /// </summary>
        /// <param name="input">Instance of ConvergencyCriterion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConvergencyCriterion input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NumberOfLatestGenerations == input.NumberOfLatestGenerations ||
                    (this.NumberOfLatestGenerations != null &&
                    this.NumberOfLatestGenerations.Equals(input.NumberOfLatestGenerations))
                ) && 
                (
                    this.PercentageOfTolerance == input.PercentageOfTolerance ||
                    (this.PercentageOfTolerance != null &&
                    this.PercentageOfTolerance.Equals(input.PercentageOfTolerance))
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
                if (this.NumberOfLatestGenerations != null)
                    hashCode = hashCode * 59 + this.NumberOfLatestGenerations.GetHashCode();
                if (this.PercentageOfTolerance != null)
                    hashCode = hashCode * 59 + this.PercentageOfTolerance.GetHashCode();
                return hashCode;
            }
        }
    }

}
