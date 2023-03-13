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
    /// AnnLayerConfig
    /// </summary>
    [DataContract]
    public partial class AnnLayerConfig : IEquatable<AnnLayerConfig>
    {
        /// <summary>
        /// Layer activation function
        /// </summary>
        /// <value>Layer activation function</value>
        [DataMember(Name = "activationFunction", EmitDefaultValue = false)]
        public NeuralNetworkActivationFunction? ActivationFunction { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AnnLayerConfig" /> class.
        /// </summary>
        /// <param name="activationFunction">Layer activation function.</param>
        /// <param name="outputs">outputs.</param>
        public AnnLayerConfig(NeuralNetworkActivationFunction? activationFunction = default(NeuralNetworkActivationFunction?), List<OutputConfig> outputs = default(List<OutputConfig>))
        {
            this.Outputs = outputs;
            this.ActivationFunction = activationFunction;
            this.Outputs = outputs;
        }

        public AnnLayerConfig() { }

        /// <summary>
        /// Gets or Sets Outputs
        /// </summary>
        [DataMember(Name="outputs", EmitDefaultValue=true)]
        public List<OutputConfig> Outputs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnnLayerConfig {\n");
            sb.Append("  ActivationFunction: ").Append(ActivationFunction).Append("\n");
            sb.Append("  Outputs: ").Append(Outputs).Append("\n");
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
            return this.Equals(input as AnnLayerConfig);
        }

        /// <summary>
        /// Returns true if AnnLayerConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of AnnLayerConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnnLayerConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ActivationFunction == input.ActivationFunction ||
                    (this.ActivationFunction != null &&
                    this.ActivationFunction.Equals(input.ActivationFunction))
                ) && 
                (
                    this.Outputs == input.Outputs ||
                    this.Outputs != null &&
                    input.Outputs != null &&
                    this.Outputs.SequenceEqual(input.Outputs)
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
                if (this.ActivationFunction != null)
                    hashCode = hashCode * 59 + this.ActivationFunction.GetHashCode();
                if (this.Outputs != null)
                    hashCode = hashCode * 59 + this.Outputs.GetHashCode();
                return hashCode;
            }
        }
    }

}
