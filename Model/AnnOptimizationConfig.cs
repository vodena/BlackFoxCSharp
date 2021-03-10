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
    /// AnnOptimizationConfig
    /// </summary>
    [DataContract]
    public partial class AnnOptimizationConfig :  IEquatable<AnnOptimizationConfig>
    {
        /// <summary>
        /// Defines the problem type. In case of binary classification,  there must be only one output column.
        /// </summary>
        /// <value>Defines the problem type. In case of binary classification,  there must be only one output column.</value>
        [DataMember(Name="problemType", EmitDefaultValue=false)]
        public ProblemType? ProblemType { get; set; }
        /// <summary>
        /// USED ONLY IN BINARY CLASSIFICATION.  Default metric: ROC_AUC (Area under ROC curve).   Depending on the task at hand, it is recommended to choose an appropriate metric to optimize.
        /// </summary>
        /// <value>USED ONLY IN BINARY CLASSIFICATION.  Default metric: ROC_AUC (Area under ROC curve).   Depending on the task at hand, it is recommended to choose an appropriate metric to optimize.</value>
        [DataMember(Name="binaryOptimizationMetric", EmitDefaultValue=false)]
        public BinaryMetric? BinaryOptimizationMetric { get; set; }
        /// <summary>
        /// USED ONLY IN REGRESSION.  Default metric: MAE (MEAN ABSOLUTE ERROR).   Depending on the task at hand, it is recommended to choose an appropriate metric to optimize.
        /// </summary>
        /// <value>USED ONLY IN REGRESSION.  Default metric: MAE (MEAN ABSOLUTE ERROR).   Depending on the task at hand, it is recommended to choose an appropriate metric to optimize.</value>
        [DataMember(Name="regressionOptimizationMetric", EmitDefaultValue=false)]
        public RegressionMetric? RegressionOptimizationMetric { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AnnOptimizationConfig" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AnnOptimizationConfig() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AnnOptimizationConfig" /> class.
        /// </summary>
        /// <param name="dropout">dropout.</param>
        /// <param name="batchSize">batchSize (default to 512).</param>
        /// <param name="datasetId">Data set id on which to train network.</param>
        /// <param name="validationSetId">Data set id on which to validate network.</param>
        /// <param name="inputs">Define min and max value for each output column(feature), and is input optional.</param>
        /// <param name="outputRanges">Define min and max value for each output column(feature).</param>
        /// <param name="problemType">Defines the problem type. In case of binary classification,  there must be only one output column..</param>
        /// <param name="binaryOptimizationMetric">USED ONLY IN BINARY CLASSIFICATION.  Default metric: ROC_AUC (Area under ROC curve).   Depending on the task at hand, it is recommended to choose an appropriate metric to optimize..</param>
        /// <param name="regressionOptimizationMetric">USED ONLY IN REGRESSION.  Default metric: MAE (MEAN ABSOLUTE ERROR).   Depending on the task at hand, it is recommended to choose an appropriate metric to optimize..</param>
        /// <param name="hiddenLayerCountRange">Range in which to search number of hidden layers.</param>
        /// <param name="neuronsPerLayer">Range in which to search number of neurons per layer.</param>
        /// <param name="trainingAlgorithms">List of training algorithms to use.</param>
        /// <param name="activationFunctions">List of activation functions to use.</param>
        /// <param name="maxEpoch">Maximum number of epoch (required) (default to 3000).</param>
        /// <param name="crossValidation">Use cross validation (default to false).</param>
        /// <param name="validationSplit">Portion of data set to use for validation, must be between 0 and 1.   Used only when CrossValidation &#x3D; false. (required) (default to 0.2D).</param>
        /// <param name="randomSeed">Random number generator seed, if the value is zero, the rows will not be randomly shuffled  Used only if CrossValidation &#x3D; false (default to 300).</param>
        /// <param name="engineConfig">Optimization engine config.</param>
        public AnnOptimizationConfig(Range dropout = default(Range), int batchSize = 512, string datasetId = default(string), string validationSetId = default(string), List<InputConfig> inputs = default(List<InputConfig>), List<Range> outputRanges = default(List<Range>), ProblemType? problemType = default(ProblemType?), BinaryMetric? binaryOptimizationMetric = default(BinaryMetric?), RegressionMetric? regressionOptimizationMetric = default(RegressionMetric?), RangeInt hiddenLayerCountRange = default(RangeInt), RangeInt neuronsPerLayer = default(RangeInt), List<NeuralNetworkTrainingAlgorithm> trainingAlgorithms = default(List<NeuralNetworkTrainingAlgorithm>), List<NeuralNetworkActivationFunction> activationFunctions = default(List<NeuralNetworkActivationFunction>), int maxEpoch = 3000, bool crossValidation = false, double validationSplit = 0.2D, int? randomSeed = 300, AnnOptimizationEngineConfig engineConfig = default(AnnOptimizationEngineConfig))
        {
            this.Dropout = dropout;
            this.DatasetId = datasetId;
            this.ValidationSetId = validationSetId;
            this.Inputs = inputs;
            this.OutputRanges = outputRanges;
            this.HiddenLayerCountRange = hiddenLayerCountRange;
            this.NeuronsPerLayer = neuronsPerLayer;
            this.TrainingAlgorithms = trainingAlgorithms;
            this.ActivationFunctions = activationFunctions;
            // to ensure "maxEpoch" is required (not null)
            if (maxEpoch == null)
            {
                throw new InvalidDataException("maxEpoch is a required property for AnnOptimizationConfig and cannot be null");
            }
            else
            {
                this.MaxEpoch = maxEpoch;
            }
            
            // to ensure "validationSplit" is required (not null)
            if (validationSplit == null)
            {
                throw new InvalidDataException("validationSplit is a required property for AnnOptimizationConfig and cannot be null");
            }
            else
            {
                this.ValidationSplit = validationSplit;
            }
            
            this.RandomSeed = randomSeed;
            this.EngineConfig = engineConfig;
            this.Dropout = dropout;
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
            this.ValidationSetId = validationSetId;
            this.Inputs = inputs;
            this.OutputRanges = outputRanges;
            this.ProblemType = problemType;
            this.BinaryOptimizationMetric = binaryOptimizationMetric;
            this.RegressionOptimizationMetric = regressionOptimizationMetric;
            this.HiddenLayerCountRange = hiddenLayerCountRange;
            this.NeuronsPerLayer = neuronsPerLayer;
            this.TrainingAlgorithms = trainingAlgorithms;
            this.ActivationFunctions = activationFunctions;
            // use default value if no "crossValidation" provided
            if (crossValidation == null)
            {
                this.CrossValidation = false;
            }
            else
            {
                this.CrossValidation = crossValidation;
            }
            // use default value if no "randomSeed" provided
            if (randomSeed == null)
            {
                this.RandomSeed = 300;
            }
            else
            {
                this.RandomSeed = randomSeed;
            }
            this.EngineConfig = engineConfig;
        }
        
        /// <summary>
        /// Gets or Sets Dropout
        /// </summary>
        [DataMember(Name="dropout", EmitDefaultValue=true)]
        public Range Dropout { get; set; }

        /// <summary>
        /// Gets or Sets BatchSize
        /// </summary>
        [DataMember(Name="batchSize", EmitDefaultValue=false)]
        public int BatchSize { get; set; }

        /// <summary>
        /// Data set id on which to train network
        /// </summary>
        /// <value>Data set id on which to train network</value>
        [DataMember(Name="datasetId", EmitDefaultValue=true)]
        public string DatasetId { get; set; }

        /// <summary>
        /// Data set id on which to validate network
        /// </summary>
        /// <value>Data set id on which to validate network</value>
        [DataMember(Name="validationSetId", EmitDefaultValue=true)]
        public string ValidationSetId { get; set; }

        /// <summary>
        /// Define min and max value for each output column(feature), and is input optional
        /// </summary>
        /// <value>Define min and max value for each output column(feature), and is input optional</value>
        [DataMember(Name="inputs", EmitDefaultValue=true)]
        public List<InputConfig> Inputs { get; set; }

        /// <summary>
        /// Define min and max value for each output column(feature)
        /// </summary>
        /// <value>Define min and max value for each output column(feature)</value>
        [DataMember(Name="outputRanges", EmitDefaultValue=true)]
        public List<Range> OutputRanges { get; set; }




        /// <summary>
        /// Range in which to search number of hidden layers
        /// </summary>
        /// <value>Range in which to search number of hidden layers</value>
        [DataMember(Name="hiddenLayerCountRange", EmitDefaultValue=true)]
        public RangeInt HiddenLayerCountRange { get; set; }

        /// <summary>
        /// Range in which to search number of neurons per layer
        /// </summary>
        /// <value>Range in which to search number of neurons per layer</value>
        [DataMember(Name="neuronsPerLayer", EmitDefaultValue=true)]
        public RangeInt NeuronsPerLayer { get; set; }

        /// <summary>
        /// List of training algorithms to use
        /// </summary>
        /// <value>List of training algorithms to use</value>
        [DataMember(Name="trainingAlgorithms", EmitDefaultValue=true)]
        public List<NeuralNetworkTrainingAlgorithm> TrainingAlgorithms { get; set; }

        /// <summary>
        /// List of activation functions to use
        /// </summary>
        /// <value>List of activation functions to use</value>
        [DataMember(Name="activationFunctions", EmitDefaultValue=true)]
        public List<NeuralNetworkActivationFunction> ActivationFunctions { get; set; }

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
        /// Optimization engine config
        /// </summary>
        /// <value>Optimization engine config</value>
        [DataMember(Name="engineConfig", EmitDefaultValue=true)]
        public AnnOptimizationEngineConfig EngineConfig { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnnOptimizationConfig {\n");
            sb.Append("  Dropout: ").Append(Dropout).Append("\n");
            sb.Append("  BatchSize: ").Append(BatchSize).Append("\n");
            sb.Append("  DatasetId: ").Append(DatasetId).Append("\n");
            sb.Append("  ValidationSetId: ").Append(ValidationSetId).Append("\n");
            sb.Append("  Inputs: ").Append(Inputs).Append("\n");
            sb.Append("  OutputRanges: ").Append(OutputRanges).Append("\n");
            sb.Append("  ProblemType: ").Append(ProblemType).Append("\n");
            sb.Append("  BinaryOptimizationMetric: ").Append(BinaryOptimizationMetric).Append("\n");
            sb.Append("  RegressionOptimizationMetric: ").Append(RegressionOptimizationMetric).Append("\n");
            sb.Append("  HiddenLayerCountRange: ").Append(HiddenLayerCountRange).Append("\n");
            sb.Append("  NeuronsPerLayer: ").Append(NeuronsPerLayer).Append("\n");
            sb.Append("  TrainingAlgorithms: ").Append(TrainingAlgorithms).Append("\n");
            sb.Append("  ActivationFunctions: ").Append(ActivationFunctions).Append("\n");
            sb.Append("  MaxEpoch: ").Append(MaxEpoch).Append("\n");
            sb.Append("  CrossValidation: ").Append(CrossValidation).Append("\n");
            sb.Append("  ValidationSplit: ").Append(ValidationSplit).Append("\n");
            sb.Append("  RandomSeed: ").Append(RandomSeed).Append("\n");
            sb.Append("  EngineConfig: ").Append(EngineConfig).Append("\n");
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
            return this.Equals(input as AnnOptimizationConfig);
        }

        /// <summary>
        /// Returns true if AnnOptimizationConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of AnnOptimizationConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnnOptimizationConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Dropout == input.Dropout ||
                    (this.Dropout != null &&
                    this.Dropout.Equals(input.Dropout))
                ) && 
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
                    this.ValidationSetId == input.ValidationSetId ||
                    (this.ValidationSetId != null &&
                    this.ValidationSetId.Equals(input.ValidationSetId))
                ) && 
                (
                    this.Inputs == input.Inputs ||
                    this.Inputs != null &&
                    input.Inputs != null &&
                    this.Inputs.SequenceEqual(input.Inputs)
                ) && 
                (
                    this.OutputRanges == input.OutputRanges ||
                    this.OutputRanges != null &&
                    input.OutputRanges != null &&
                    this.OutputRanges.SequenceEqual(input.OutputRanges)
                ) && 
                (
                    this.ProblemType == input.ProblemType ||
                    (this.ProblemType != null &&
                    this.ProblemType.Equals(input.ProblemType))
                ) && 
                (
                    this.BinaryOptimizationMetric == input.BinaryOptimizationMetric ||
                    (this.BinaryOptimizationMetric != null &&
                    this.BinaryOptimizationMetric.Equals(input.BinaryOptimizationMetric))
                ) && 
                (
                    this.RegressionOptimizationMetric == input.RegressionOptimizationMetric ||
                    (this.RegressionOptimizationMetric != null &&
                    this.RegressionOptimizationMetric.Equals(input.RegressionOptimizationMetric))
                ) && 
                (
                    this.HiddenLayerCountRange == input.HiddenLayerCountRange ||
                    (this.HiddenLayerCountRange != null &&
                    this.HiddenLayerCountRange.Equals(input.HiddenLayerCountRange))
                ) && 
                (
                    this.NeuronsPerLayer == input.NeuronsPerLayer ||
                    (this.NeuronsPerLayer != null &&
                    this.NeuronsPerLayer.Equals(input.NeuronsPerLayer))
                ) && 
                (
                    this.TrainingAlgorithms == input.TrainingAlgorithms ||
                    this.TrainingAlgorithms != null &&
                    input.TrainingAlgorithms != null &&
                    this.TrainingAlgorithms.SequenceEqual(input.TrainingAlgorithms)
                ) && 
                (
                    this.ActivationFunctions == input.ActivationFunctions ||
                    this.ActivationFunctions != null &&
                    input.ActivationFunctions != null &&
                    this.ActivationFunctions.SequenceEqual(input.ActivationFunctions)
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
                ) && 
                (
                    this.EngineConfig == input.EngineConfig ||
                    (this.EngineConfig != null &&
                    this.EngineConfig.Equals(input.EngineConfig))
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
                if (this.Dropout != null)
                    hashCode = hashCode * 59 + this.Dropout.GetHashCode();
                if (this.BatchSize != null)
                    hashCode = hashCode * 59 + this.BatchSize.GetHashCode();
                if (this.DatasetId != null)
                    hashCode = hashCode * 59 + this.DatasetId.GetHashCode();
                if (this.ValidationSetId != null)
                    hashCode = hashCode * 59 + this.ValidationSetId.GetHashCode();
                if (this.Inputs != null)
                    hashCode = hashCode * 59 + this.Inputs.GetHashCode();
                if (this.OutputRanges != null)
                    hashCode = hashCode * 59 + this.OutputRanges.GetHashCode();
                if (this.ProblemType != null)
                    hashCode = hashCode * 59 + this.ProblemType.GetHashCode();
                if (this.BinaryOptimizationMetric != null)
                    hashCode = hashCode * 59 + this.BinaryOptimizationMetric.GetHashCode();
                if (this.RegressionOptimizationMetric != null)
                    hashCode = hashCode * 59 + this.RegressionOptimizationMetric.GetHashCode();
                if (this.HiddenLayerCountRange != null)
                    hashCode = hashCode * 59 + this.HiddenLayerCountRange.GetHashCode();
                if (this.NeuronsPerLayer != null)
                    hashCode = hashCode * 59 + this.NeuronsPerLayer.GetHashCode();
                if (this.TrainingAlgorithms != null)
                    hashCode = hashCode * 59 + this.TrainingAlgorithms.GetHashCode();
                if (this.ActivationFunctions != null)
                    hashCode = hashCode * 59 + this.ActivationFunctions.GetHashCode();
                if (this.MaxEpoch != null)
                    hashCode = hashCode * 59 + this.MaxEpoch.GetHashCode();
                if (this.CrossValidation != null)
                    hashCode = hashCode * 59 + this.CrossValidation.GetHashCode();
                if (this.ValidationSplit != null)
                    hashCode = hashCode * 59 + this.ValidationSplit.GetHashCode();
                if (this.RandomSeed != null)
                    hashCode = hashCode * 59 + this.RandomSeed.GetHashCode();
                if (this.EngineConfig != null)
                    hashCode = hashCode * 59 + this.EngineConfig.GetHashCode();
                return hashCode;
            }
        }
    }

}
