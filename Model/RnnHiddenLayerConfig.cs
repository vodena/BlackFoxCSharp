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
    /// Hidden layer confuguration for recurrent network
    /// </summary>
    [DataContract]
    public partial class RnnHiddenLayerConfig :  IEquatable<RnnHiddenLayerConfig>
    {
        /// <summary>
        /// Recurrent activation function
        /// </summary>
        /// <value>Recurrent activation function</value>
        [DataMember(Name="recurrentActivationFunction", EmitDefaultValue=false)]
        public NeuralNetworkActivationFunction? RecurrentActivationFunction { get; set; }
        /// <summary>
        /// Layer activation function
        /// </summary>
        /// <value>Layer activation function</value>
        [DataMember(Name="activationFunction", EmitDefaultValue=false)]
        public NeuralNetworkActivationFunction? ActivationFunction { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RnnHiddenLayerConfig" /> class.
        /// </summary>
        /// <param name="recurrentActivationFunction">Recurrent activation function.</param>
        /// <param name="recurrentDropout">Recurrent dropout.</param>
        /// <param name="neuronCount">Number of neurons in layer.</param>
        /// <param name="activationFunction">Layer activation function.</param>
        /// <param name="dropout">Layer dropout.</param>
        public RnnHiddenLayerConfig(NeuralNetworkActivationFunction? recurrentActivationFunction = default(NeuralNetworkActivationFunction?), double? recurrentDropout = default(double?), int neuronCount = default(int), NeuralNetworkActivationFunction? activationFunction = default(NeuralNetworkActivationFunction?), double dropout = default(double))
        {
            this.RecurrentDropout = recurrentDropout;
            this.RecurrentActivationFunction = recurrentActivationFunction;
            this.RecurrentDropout = recurrentDropout;
            this.NeuronCount = neuronCount;
            this.ActivationFunction = activationFunction;
            this.Dropout = dropout;
        }

        public RnnHiddenLayerConfig() { }

        /// <summary>
        /// Recurrent dropout
        /// </summary>
        /// <value>Recurrent dropout</value>
        [DataMember(Name="recurrentDropout", EmitDefaultValue=true)]
        public double? RecurrentDropout { get; set; }

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
            sb.Append("class RnnHiddenLayerConfig {\n");
            sb.Append("  RecurrentActivationFunction: ").Append(RecurrentActivationFunction).Append("\n");
            sb.Append("  RecurrentDropout: ").Append(RecurrentDropout).Append("\n");
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
            return this.Equals(input as RnnHiddenLayerConfig);
        }

        /// <summary>
        /// Returns true if RnnHiddenLayerConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of RnnHiddenLayerConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RnnHiddenLayerConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RecurrentActivationFunction == input.RecurrentActivationFunction ||
                    (this.RecurrentActivationFunction != null &&
                    this.RecurrentActivationFunction.Equals(input.RecurrentActivationFunction))
                ) && 
                (
                    this.RecurrentDropout == input.RecurrentDropout ||
                    (this.RecurrentDropout != null &&
                    this.RecurrentDropout.Equals(input.RecurrentDropout))
                ) && 
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
                if (this.RecurrentActivationFunction != null)
                    hashCode = hashCode * 59 + this.RecurrentActivationFunction.GetHashCode();
                if (this.RecurrentDropout != null)
                    hashCode = hashCode * 59 + this.RecurrentDropout.GetHashCode();
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
