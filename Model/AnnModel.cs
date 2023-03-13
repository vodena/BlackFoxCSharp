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
    /// AnnModel
    /// </summary>
    [DataContract]
    public partial class AnnModel :  IEquatable<AnnModel>
    {
        /// <summary>
        /// Algorithm on which model was trained
        /// </summary>
        /// <value>Algorithm on which model was trained</value>
        [DataMember(Name="trainingAlgorithm", EmitDefaultValue=false)]
        public NeuralNetworkTrainingAlgorithm? TrainingAlgorithm { get; set; }
        /// <summary>
        /// Activation function on output layer
        /// </summary>
        /// <value>Activation function on output layer</value>
        [DataMember(Name="outputLayerActivationFunction", EmitDefaultValue=false)]
        public NeuralNetworkActivationFunction? OutputLayerActivationFunction { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AnnModel" /> class.
        /// </summary>
        /// <param name="hiddenLayers">List of hidden layers.</param>
        /// <param name="trainingAlgorithm">Algorithm on which model was trained.</param>
        /// <param name="outputLayerActivationFunction">Activation function on output layer.</param>
        /// <param name="featureSelection">А bool value for each input indicating whether that input is significant.</param>
        public AnnModel(List<AnnHiddenLayerConfig> hiddenLayers = default(List<AnnHiddenLayerConfig>), NeuralNetworkTrainingAlgorithm? trainingAlgorithm = default(NeuralNetworkTrainingAlgorithm?), NeuralNetworkActivationFunction? outputLayerActivationFunction = default(NeuralNetworkActivationFunction?), List<bool> featureSelection = default(List<bool>))
        {
            this.HiddenLayers = hiddenLayers;
            this.FeatureSelection = featureSelection;
            this.HiddenLayers = hiddenLayers;
            this.TrainingAlgorithm = trainingAlgorithm;
            this.OutputLayerActivationFunction = outputLayerActivationFunction;
            this.FeatureSelection = featureSelection;
        }
        public AnnModel() { }

        /// <summary>
        /// List of hidden layers
        /// </summary>
        /// <value>List of hidden layers</value>
        [DataMember(Name="hiddenLayers", EmitDefaultValue=true)]
        public List<AnnHiddenLayerConfig> HiddenLayers { get; set; }



        /// <summary>
        /// А bool value for each input indicating whether that input is significant
        /// </summary>
        /// <value>А bool value for each input indicating whether that input is significant</value>
        [DataMember(Name="featureSelection", EmitDefaultValue=true)]
        public List<bool> FeatureSelection { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnnModel {\n");
            sb.Append("  HiddenLayers: ").Append(HiddenLayers).Append("\n");
            sb.Append("  TrainingAlgorithm: ").Append(TrainingAlgorithm).Append("\n");
            sb.Append("  OutputLayerActivationFunction: ").Append(OutputLayerActivationFunction).Append("\n");
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
            return this.Equals(input as AnnModel);
        }

        /// <summary>
        /// Returns true if AnnModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AnnModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnnModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HiddenLayers == input.HiddenLayers ||
                    this.HiddenLayers != null &&
                    input.HiddenLayers != null &&
                    this.HiddenLayers.SequenceEqual(input.HiddenLayers)
                ) && 
                (
                    this.TrainingAlgorithm == input.TrainingAlgorithm ||
                    (this.TrainingAlgorithm != null &&
                    this.TrainingAlgorithm.Equals(input.TrainingAlgorithm))
                ) && 
                (
                    this.OutputLayerActivationFunction == input.OutputLayerActivationFunction ||
                    (this.OutputLayerActivationFunction != null &&
                    this.OutputLayerActivationFunction.Equals(input.OutputLayerActivationFunction))
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
                if (this.HiddenLayers != null)
                    hashCode = hashCode * 59 + this.HiddenLayers.GetHashCode();
                if (this.TrainingAlgorithm != null)
                    hashCode = hashCode * 59 + this.TrainingAlgorithm.GetHashCode();
                if (this.OutputLayerActivationFunction != null)
                    hashCode = hashCode * 59 + this.OutputLayerActivationFunction.GetHashCode();
                if (this.FeatureSelection != null)
                    hashCode = hashCode * 59 + this.FeatureSelection.GetHashCode();
                return hashCode;
            }
        }
    }

}
