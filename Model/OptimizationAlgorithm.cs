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
    /// Defines OptimizationAlgorithm
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum OptimizationAlgorithm
    {
        /// <summary>
        /// Enum SimpleGA for value: SimpleGA
        /// </summary>
        [EnumMember(Value = "SimpleGA")]
        SimpleGA = 1,

        /// <summary>
        /// Enum VidnerovaNeruda for value: VidnerovaNeruda
        /// </summary>
        [EnumMember(Value = "VidnerovaNeruda")]
        VidnerovaNeruda = 2

    }

}