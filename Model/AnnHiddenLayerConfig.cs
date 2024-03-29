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
    /// Generic hidden layer configuration
    /// </summary>
    [DataContract]
    public partial class AnnHiddenLayerConfig : IEquatable<AnnHiddenLayerConfig>
    {
        /// <summary>
        /// Layer activation function
        /// </summary>
        /// <value>Layer activation function</value>
        [DataMember(Name = "activationFunction", EmitDefaultValue = false)]
        public NeuralNetworkActivationFunction? ActivationFunction { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AnnHiddenLayerConfig" /> class.
        /// </summary>
        /// <param name="neuronCount">Number of neurons in layer.</param>
        /// <param name="activationFunction">Layer activation function.</param>
        /// <param name="dropout">Layer dropout.</param>
        public AnnHiddenLayerConfig(int neuronCount = default(int), NeuralNetworkActivationFunction? activationFunction = default(NeuralNetworkActivationFunction?), double dropout = default(double))
        {
            this.NeuronCount = neuronCount;
            this.ActivationFunction = activationFunction;
            this.Dropout = dropout;
        }

        public AnnHiddenLayerConfig() { }

        /// <summary>
        /// Number of neurons in layer
        /// </summary>
        /// <value>Number of neurons in layer</value>
        [DataMember(Name="neuronCount", EmitDefaultValue=false)]
        public int NeuronCount { get; set; }


        /// <summary>
        /// Layer dropout
        /// </summary>
        /// <value>Layer dropout</value>
        [DataMember(Name="dropout", EmitDefaultValue=false)]
        public double Dropout { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnnHiddenLayerConfig {\n");
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
            return this.Equals(input as AnnHiddenLayerConfig);
        }

        /// <summary>
        /// Returns true if AnnHiddenLayerConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of AnnHiddenLayerConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnnHiddenLayerConfig input)
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
