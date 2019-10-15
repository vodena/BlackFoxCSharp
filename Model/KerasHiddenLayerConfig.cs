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
    /// Generic hidden layer configuration
    /// </summary>
    [DataContract]
    public partial class KerasHiddenLayerConfig :  IEquatable<KerasHiddenLayerConfig>
    {
        /// <summary>
        /// Layer activation function
        /// </summary>
        /// <value>Layer activation function</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActivationFunctionEnum
        {
            
            /// <summary>
            /// Enum SoftMax for value: SoftMax
            /// </summary>
            [EnumMember(Value = "SoftMax")]
            SoftMax = 1,
            
            /// <summary>
            /// Enum Elu for value: Elu
            /// </summary>
            [EnumMember(Value = "Elu")]
            Elu = 2,
            
            /// <summary>
            /// Enum Selu for value: Selu
            /// </summary>
            [EnumMember(Value = "Selu")]
            Selu = 3,
            
            /// <summary>
            /// Enum SoftPlus for value: SoftPlus
            /// </summary>
            [EnumMember(Value = "SoftPlus")]
            SoftPlus = 4,
            
            /// <summary>
            /// Enum SoftSign for value: SoftSign
            /// </summary>
            [EnumMember(Value = "SoftSign")]
            SoftSign = 5,
            
            /// <summary>
            /// Enum ReLu for value: ReLu
            /// </summary>
            [EnumMember(Value = "ReLu")]
            ReLu = 6,
            
            /// <summary>
            /// Enum TanH for value: TanH
            /// </summary>
            [EnumMember(Value = "TanH")]
            TanH = 7,
            
            /// <summary>
            /// Enum Sigmoid for value: Sigmoid
            /// </summary>
            [EnumMember(Value = "Sigmoid")]
            Sigmoid = 8,
            
            /// <summary>
            /// Enum HardSigmoid for value: HardSigmoid
            /// </summary>
            [EnumMember(Value = "HardSigmoid")]
            HardSigmoid = 9,
            
            /// <summary>
            /// Enum Linear for value: Linear
            /// </summary>
            [EnumMember(Value = "Linear")]
            Linear = 10
        }

        /// <summary>
        /// Layer activation function
        /// </summary>
        /// <value>Layer activation function</value>
        [DataMember(Name="activationFunction", EmitDefaultValue=false)]
        public ActivationFunctionEnum? ActivationFunction { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KerasHiddenLayerConfig" /> class.
        /// </summary>
        /// <param name="neuronCount">Number of neurons in layer.</param>
        /// <param name="activationFunction">Layer activation function.</param>
        /// <param name="dropout">Layer dropout.</param>
        public KerasHiddenLayerConfig(int? neuronCount = default(int?), ActivationFunctionEnum? activationFunction = default(ActivationFunctionEnum?), double? dropout = default(double?))
        {
            this.NeuronCount = neuronCount;
            this.ActivationFunction = activationFunction;
            this.Dropout = dropout;
        }

        public KerasHiddenLayerConfig()
        {

        }
        
        /// <summary>
        /// Number of neurons in layer
        /// </summary>
        /// <value>Number of neurons in layer</value>
        [DataMember(Name="neuronCount", EmitDefaultValue=false)]
        public int? NeuronCount { get; set; }


        /// <summary>
        /// Layer dropout
        /// </summary>
        /// <value>Layer dropout</value>
        [DataMember(Name="dropout", EmitDefaultValue=false)]
        public double? Dropout { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KerasHiddenLayerConfig {\n");
            sb.Append("  NeuronCount: ").Append(NeuronCount).Append("\n");
            sb.Append("  ActivationFunction: ").Append(ActivationFunction).Append("\n");
            sb.Append("  Dropout: ").Append(Dropout).Append("\n");
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
            return this.Equals(input as KerasHiddenLayerConfig);
        }

        /// <summary>
        /// Returns true if KerasHiddenLayerConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of KerasHiddenLayerConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KerasHiddenLayerConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NeuronCount == input.NeuronCount ||
                    (this.NeuronCount != null &&
                    this.NeuronCount.Equals(input.NeuronCount))
                ) && 
                (
                    this.ActivationFunction == input.ActivationFunction ||
                    (this.ActivationFunction != null &&
                    this.ActivationFunction.Equals(input.ActivationFunction))
                ) && 
                (
                    this.Dropout == input.Dropout ||
                    (this.Dropout != null &&
                    this.Dropout.Equals(input.Dropout))
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
                if (this.NeuronCount != null)
                    hashCode = hashCode * 59 + this.NeuronCount.GetHashCode();
                if (this.ActivationFunction != null)
                    hashCode = hashCode * 59 + this.ActivationFunction.GetHashCode();
                if (this.Dropout != null)
                    hashCode = hashCode * 59 + this.Dropout.GetHashCode();
                return hashCode;
            }
        }
    }

}
