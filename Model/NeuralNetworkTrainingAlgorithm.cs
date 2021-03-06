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
    /// Defines NeuralNetworkTrainingAlgorithm
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum NeuralNetworkTrainingAlgorithm
    {
        /// <summary>
        /// Enum SGD for value: SGD
        /// </summary>
        [EnumMember(Value = "SGD")]
        SGD = 1,

        /// <summary>
        /// Enum RMSprop for value: RMSprop
        /// </summary>
        [EnumMember(Value = "RMSprop")]
        RMSprop = 2,

        /// <summary>
        /// Enum Adagrad for value: Adagrad
        /// </summary>
        [EnumMember(Value = "Adagrad")]
        Adagrad = 3,

        /// <summary>
        /// Enum Adadelta for value: Adadelta
        /// </summary>
        [EnumMember(Value = "Adadelta")]
        Adadelta = 4,

        /// <summary>
        /// Enum Adam for value: Adam
        /// </summary>
        [EnumMember(Value = "Adam")]
        Adam = 5,

        /// <summary>
        /// Enum Adamax for value: Adamax
        /// </summary>
        [EnumMember(Value = "Adamax")]
        Adamax = 6,

        /// <summary>
        /// Enum Nadam for value: Nadam
        /// </summary>
        [EnumMember(Value = "Nadam")]
        Nadam = 7

    }

}
