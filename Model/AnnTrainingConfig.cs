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
    /// AnnTrainingConfig
    /// </summary>
    [DataContract]
    public partial class AnnTrainingConfig :  IEquatable<AnnTrainingConfig>
    {
        /// <summary>
        /// Training algorithm to use
        /// </summary>
        /// <value>Training algorithm to use</value>
        [DataMember(Name="trainingAlgorithm", EmitDefaultValue=false)]
        public NeuralNetworkTrainingAlgorithm? TrainingAlgorithm { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AnnTrainingConfig" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public AnnTrainingConfig() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AnnTrainingConfig" /> class.
        /// </summary>
        /// <param name="batchSize">Training batch size (default to 512).</param>
        /// <param name="datasetId">Data set id on which to train network.</param>
        /// <param name="inputRanges">Define min and max value for each input column(feature).</param>
        /// <param name="outputLayer">Define min and max value for each output column(feature), and output activation function.</param>
        /// <param name="hiddenLayerConfigs">Hidden layers configuration.</param>
        /// <param name="trainingAlgorithm">Training algorithm to use.</param>
        /// <param name="maxEpoch">Maximum number of epoch (required).</param>
        /// <param name="crossValidation">Use cross validation.</param>
        /// <param name="validationSplit">Portion of data set to use for validation, must be between 0 and 1.   Used only when CrossValidation &#x3D; false. (required).</param>
        /// <param name="randomSeed">Random number generator seed, if the value is zero, the rows will not be randomly shuffled  Used only if CrossValidation &#x3D; false.</param>
        public AnnTrainingConfig(int batchSize = 512, string datasetId = default(string), List<InputConfig> inputRanges = default(List<InputConfig>), AnnLayerConfig outputLayer = default(AnnLayerConfig), List<AnnHiddenLayerConfig> hiddenLayerConfigs = default(List<AnnHiddenLayerConfig>), NeuralNetworkTrainingAlgorithm? trainingAlgorithm = default(NeuralNetworkTrainingAlgorithm?), int maxEpoch = default(int), bool crossValidation = default(bool), double validationSplit = default(double), int? randomSeed = default(int?))
        {
            this.DatasetId = datasetId;
            this.InputRanges = inputRanges;
            this.OutputLayer = outputLayer;
            this.HiddenLayerConfigs = hiddenLayerConfigs;
            // to ensure "maxEpoch" is required (not null)
            if (maxEpoch == null)
            {
                throw new InvalidDataException("maxEpoch is a required property for AnnTrainingConfig and cannot be null");
            }
            else
            {
                this.MaxEpoch = maxEpoch;
            }
            
            // to ensure "validationSplit" is required (not null)
            if (validationSplit == null)
            {
                throw new InvalidDataException("validationSplit is a required property for AnnTrainingConfig and cannot be null");
            }
            else
            {
                this.ValidationSplit = validationSplit;
            }
            
            this.RandomSeed = randomSeed;
            // use default value if no "batchSize" provided
            if (batchSize == null)
            {
                this.BatchSize = 512;
            }
            else
            {
                this.BatchSize = batchSize;
            }
            this.DatasetId = datasetId;
            this.InputRanges = inputRanges;
            this.OutputLayer = outputLayer;
            this.HiddenLayerConfigs = hiddenLayerConfigs;
            this.TrainingAlgorithm = trainingAlgorithm;
            this.CrossValidation = crossValidation;
            this.RandomSeed = randomSeed;
        }
        
        /// <summary>
        /// Training batch size
        /// </summary>
        /// <value>Training batch size</value>
        [DataMember(Name="batchSize", EmitDefaultValue=false)]
        public int BatchSize { get; set; }

        /// <summary>
        /// Data set id on which to train network
        /// </summary>
        /// <value>Data set id on which to train network</value>
        [DataMember(Name="datasetId", EmitDefaultValue=true)]
        public string DatasetId { get; set; }

        /// <summary>
        /// Define min and max value for each input column(feature)
        /// </summary>
        /// <value>Define min and max value for each input column(feature)</value>
        [DataMember(Name="inputRanges", EmitDefaultValue=true)]
        public List<InputConfig> InputRanges { get; set; }

        /// <summary>
        /// Define min and max value for each output column(feature), and output activation function
        /// </summary>
        /// <value>Define min and max value for each output column(feature), and output activation function</value>
        [DataMember(Name="outputLayer", EmitDefaultValue=true)]
        public AnnLayerConfig OutputLayer { get; set; }

        /// <summary>
        /// Hidden layers configuration
        /// </summary>
        /// <value>Hidden layers configuration</value>
        [DataMember(Name="hiddenLayerConfigs", EmitDefaultValue=true)]
        public List<AnnHiddenLayerConfig> HiddenLayerConfigs { get; set; }


        /// <summary>
        /// Maximum number of epoch
        /// </summary>
        /// <value>Maximum number of epoch</value>
        [DataMember(Name="maxEpoch", EmitDefaultValue=true)]
        public int MaxEpoch { get; set; }

        /// <summary>
        /// Use cross validation
        /// </summary>
        /// <value>Use cross validation</value>
        [DataMember(Name="crossValidation", EmitDefaultValue=false)]
        public bool CrossValidation { get; set; }

        /// <summary>
        /// Portion of data set to use for validation, must be between 0 and 1.   Used only when CrossValidation &#x3D; false.
        /// </summary>
        /// <value>Portion of data set to use for validation, must be between 0 and 1.   Used only when CrossValidation &#x3D; false.</value>
        [DataMember(Name="validationSplit", EmitDefaultValue=true)]
        public double ValidationSplit { get; set; }

        /// <summary>
        /// Random number generator seed, if the value is zero, the rows will not be randomly shuffled  Used only if CrossValidation &#x3D; false
        /// </summary>
        /// <value>Random number generator seed, if the value is zero, the rows will not be randomly shuffled  Used only if CrossValidation &#x3D; false</value>
        [DataMember(Name="randomSeed", EmitDefaultValue=true)]
        public int? RandomSeed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnnTrainingConfig {\n");
            sb.Append("  BatchSize: ").Append(BatchSize).Append("\n");
            sb.Append("  DatasetId: ").Append(DatasetId).Append("\n");
            sb.Append("  InputRanges: ").Append(InputRanges).Append("\n");
            sb.Append("  OutputLayer: ").Append(OutputLayer).Append("\n");
            sb.Append("  HiddenLayerConfigs: ").Append(HiddenLayerConfigs).Append("\n");
            sb.Append("  TrainingAlgorithm: ").Append(TrainingAlgorithm).Append("\n");
            sb.Append("  MaxEpoch: ").Append(MaxEpoch).Append("\n");
            sb.Append("  CrossValidation: ").Append(CrossValidation).Append("\n");
            sb.Append("  ValidationSplit: ").Append(ValidationSplit).Append("\n");
            sb.Append("  RandomSeed: ").Append(RandomSeed).Append("\n");
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
            return this.Equals(input as AnnTrainingConfig);
        }

        /// <summary>
        /// Returns true if AnnTrainingConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of AnnTrainingConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnnTrainingConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BatchSize == input.BatchSize ||
                    (this.BatchSize != null &&
                    this.BatchSize.Equals(input.BatchSize))
                ) && 
                (
                    this.DatasetId == input.DatasetId ||
                    (this.DatasetId != null &&
                    this.DatasetId.Equals(input.DatasetId))
                ) && 
                (
                    this.InputRanges == input.InputRanges ||
                    this.InputRanges != null &&
                    input.InputRanges != null &&
                    this.InputRanges.SequenceEqual(input.InputRanges)
                ) && 
                (
                    this.OutputLayer == input.OutputLayer ||
                    (this.OutputLayer != null &&
                    this.OutputLayer.Equals(input.OutputLayer))
                ) && 
                (
                    this.HiddenLayerConfigs == input.HiddenLayerConfigs ||
                    this.HiddenLayerConfigs != null &&
                    input.HiddenLayerConfigs != null &&
                    this.HiddenLayerConfigs.SequenceEqual(input.HiddenLayerConfigs)
                ) && 
                (
                    this.TrainingAlgorithm == input.TrainingAlgorithm ||
                    (this.TrainingAlgorithm != null &&
                    this.TrainingAlgorithm.Equals(input.TrainingAlgorithm))
                ) && 
                (
                    this.MaxEpoch == input.MaxEpoch ||
                    (this.MaxEpoch != null &&
                    this.MaxEpoch.Equals(input.MaxEpoch))
                ) && 
                (
                    this.CrossValidation == input.CrossValidation ||
                    (this.CrossValidation != null &&
                    this.CrossValidation.Equals(input.CrossValidation))
                ) && 
                (
                    this.ValidationSplit == input.ValidationSplit ||
                    (this.ValidationSplit != null &&
                    this.ValidationSplit.Equals(input.ValidationSplit))
                ) && 
                (
                    this.RandomSeed == input.RandomSeed ||
                    (this.RandomSeed != null &&
                    this.RandomSeed.Equals(input.RandomSeed))
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
                if (this.BatchSize != null)
                    hashCode = hashCode * 59 + this.BatchSize.GetHashCode();
                if (this.DatasetId != null)
                    hashCode = hashCode * 59 + this.DatasetId.GetHashCode();
                if (this.InputRanges != null)
                    hashCode = hashCode * 59 + this.InputRanges.GetHashCode();
                if (this.OutputLayer != null)
                    hashCode = hashCode * 59 + this.OutputLayer.GetHashCode();
                if (this.HiddenLayerConfigs != null)
                    hashCode = hashCode * 59 + this.HiddenLayerConfigs.GetHashCode();
                if (this.TrainingAlgorithm != null)
                    hashCode = hashCode * 59 + this.TrainingAlgorithm.GetHashCode();
                if (this.MaxEpoch != null)
                    hashCode = hashCode * 59 + this.MaxEpoch.GetHashCode();
                if (this.CrossValidation != null)
                    hashCode = hashCode * 59 + this.CrossValidation.GetHashCode();
                if (this.ValidationSplit != null)
                    hashCode = hashCode * 59 + this.ValidationSplit.GetHashCode();
                if (this.RandomSeed != null)
                    hashCode = hashCode * 59 + this.RandomSeed.GetHashCode();
                return hashCode;
            }
        }
    }

}
