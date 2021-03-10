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
    /// Defines RegressionMetric
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum RegressionMetric
    {
        /// <summary>
        /// Enum MAE for value: MAE
        /// </summary>
        [EnumMember(Value = "MAE")]
        MAE = 1,

        /// <summary>
        /// Enum MAPE for value: MAPE
        /// </summary>
        [EnumMember(Value = "MAPE")]
        MAPE = 2,

        /// <summary>
        /// Enum MSE for value: MSE
        /// </summary>
        [EnumMember(Value = "MSE")]
        MSE = 3

    }

}
