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
    /// Defines NeuralNetworkActivationFunction
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum NeuralNetworkActivationFunction
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

}
