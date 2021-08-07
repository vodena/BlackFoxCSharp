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
    /// XGBoostModel definition
    /// </summary>
    [DataContract]
    public partial class XGBoostModel :  IEquatable<XGBoostModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XGBoostModel" /> class.
        /// </summary>
        /// <param name="nEstimators">NEstimators.</param>
        /// <param name="maxDepth">MaxDepth.</param>
        /// <param name="minChildWeight">MinChildWeight.</param>
        /// <param name="gamma">Gamma.</param>
        /// <param name="subsample">Subsample.</param>
        /// <param name="colsampleBytree">ColsampleBytree.</param>
        /// <param name="regAlpha">RegAlpha.</param>
        /// <param name="learningRate">LearningRate.</param>
        /// <param name="featureSelection">Feature selection list.</param>
        public XGBoostModel(int nEstimators = default(int), int maxDepth = default(int), int minChildWeight = default(int), double gamma = default(double), double subsample = default(double), double colsampleBytree = default(double), double regAlpha = default(double), double learningRate = default(double), List<bool> featureSelection = default(List<bool>))
        {
            this.FeatureSelection = featureSelection;
            this.NEstimators = nEstimators;
            this.MaxDepth = maxDepth;
            this.MinChildWeight = minChildWeight;
            this.Gamma = gamma;
            this.Subsample = subsample;
            this.ColsampleBytree = colsampleBytree;
            this.RegAlpha = regAlpha;
            this.LearningRate = learningRate;
        }
        [JsonConstructorAttribute]
        protected XGBoostModel() { }
        /// <summary>
        /// NEstimators
        /// </summary>
        /// <value>NEstimators</value>
        [DataMember(Name="nEstimators", EmitDefaultValue=false)]
        public int NEstimators { get; set; }

        /// <summary>
        /// MaxDepth
        /// </summary>
        /// <value>MaxDepth</value>
        [DataMember(Name="maxDepth", EmitDefaultValue=false)]
        public int MaxDepth { get; set; }

        /// <summary>
        /// MinChildWeight
        /// </summary>
        /// <value>MinChildWeight</value>
        [DataMember(Name="minChildWeight", EmitDefaultValue=false)]
        public int MinChildWeight { get; set; }

        /// <summary>
        /// Gamma
        /// </summary>
        /// <value>Gamma</value>
        [DataMember(Name="gamma", EmitDefaultValue=false)]
        public double Gamma { get; set; }

        /// <summary>
        /// Subsample
        /// </summary>
        /// <value>Subsample</value>
        [DataMember(Name="subsample", EmitDefaultValue=false)]
        public double Subsample { get; set; }

        /// <summary>
        /// ColsampleBytree
        /// </summary>
        /// <value>ColsampleBytree</value>
        [DataMember(Name="colsampleBytree", EmitDefaultValue=false)]
        public double ColsampleBytree { get; set; }

        /// <summary>
        /// RegAlpha
        /// </summary>
        /// <value>RegAlpha</value>
        [DataMember(Name="regAlpha", EmitDefaultValue=false)]
        public double RegAlpha { get; set; }

        /// <summary>
        /// LearningRate
        /// </summary>
        /// <value>LearningRate</value>
        [DataMember(Name="learningRate", EmitDefaultValue=false)]
        public double LearningRate { get; set; }

        /// <summary>
        /// Feature selection list
        /// </summary>
        /// <value>Feature selection list</value>
        [DataMember(Name="featureSelection", EmitDefaultValue=true)]
        public List<bool> FeatureSelection { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XGBoostModel {\n");
            sb.Append("  NEstimators: ").Append(NEstimators).Append("\n");
            sb.Append("  MaxDepth: ").Append(MaxDepth).Append("\n");
            sb.Append("  MinChildWeight: ").Append(MinChildWeight).Append("\n");
            sb.Append("  Gamma: ").Append(Gamma).Append("\n");
            sb.Append("  Subsample: ").Append(Subsample).Append("\n");
            sb.Append("  ColsampleBytree: ").Append(ColsampleBytree).Append("\n");
            sb.Append("  RegAlpha: ").Append(RegAlpha).Append("\n");
            sb.Append("  LearningRate: ").Append(LearningRate).Append("\n");
            sb.Append("  FeatureSelection: ").Append(FeatureSelection).Append("\n");
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
            return this.Equals(input as XGBoostModel);
        }

        /// <summary>
        /// Returns true if XGBoostModel instances are equal
        /// </summary>
        /// <param name="input">Instance of XGBoostModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XGBoostModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NEstimators == input.NEstimators ||
                    (this.NEstimators != null &&
                    this.NEstimators.Equals(input.NEstimators))
                ) && 
                (
                    this.MaxDepth == input.MaxDepth ||
                    (this.MaxDepth != null &&
                    this.MaxDepth.Equals(input.MaxDepth))
                ) && 
                (
                    this.MinChildWeight == input.MinChildWeight ||
                    (this.MinChildWeight != null &&
                    this.MinChildWeight.Equals(input.MinChildWeight))
                ) && 
                (
                    this.Gamma == input.Gamma ||
                    (this.Gamma != null &&
                    this.Gamma.Equals(input.Gamma))
                ) && 
                (
                    this.Subsample == input.Subsample ||
                    (this.Subsample != null &&
                    this.Subsample.Equals(input.Subsample))
                ) && 
                (
                    this.ColsampleBytree == input.ColsampleBytree ||
                    (this.ColsampleBytree != null &&
                    this.ColsampleBytree.Equals(input.ColsampleBytree))
                ) && 
                (
                    this.RegAlpha == input.RegAlpha ||
                    (this.RegAlpha != null &&
                    this.RegAlpha.Equals(input.RegAlpha))
                ) && 
                (
                    this.LearningRate == input.LearningRate ||
                    (this.LearningRate != null &&
                    this.LearningRate.Equals(input.LearningRate))
                ) && 
                (
                    this.FeatureSelection == input.FeatureSelection ||
                    this.FeatureSelection != null &&
                    input.FeatureSelection != null &&
                    this.FeatureSelection.SequenceEqual(input.FeatureSelection)
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
                if (this.NEstimators != null)
                    hashCode = hashCode * 59 + this.NEstimators.GetHashCode();
                if (this.MaxDepth != null)
                    hashCode = hashCode * 59 + this.MaxDepth.GetHashCode();
                if (this.MinChildWeight != null)
                    hashCode = hashCode * 59 + this.MinChildWeight.GetHashCode();
                if (this.Gamma != null)
                    hashCode = hashCode * 59 + this.Gamma.GetHashCode();
                if (this.Subsample != null)
                    hashCode = hashCode * 59 + this.Subsample.GetHashCode();
                if (this.ColsampleBytree != null)
                    hashCode = hashCode * 59 + this.ColsampleBytree.GetHashCode();
                if (this.RegAlpha != null)
                    hashCode = hashCode * 59 + this.RegAlpha.GetHashCode();
                if (this.LearningRate != null)
                    hashCode = hashCode * 59 + this.LearningRate.GetHashCode();
                if (this.FeatureSelection != null)
                    hashCode = hashCode * 59 + this.FeatureSelection.GetHashCode();
                return hashCode;
            }
        }
    }

}
