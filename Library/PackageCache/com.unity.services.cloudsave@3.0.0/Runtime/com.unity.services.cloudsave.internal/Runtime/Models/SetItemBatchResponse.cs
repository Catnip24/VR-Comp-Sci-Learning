//-----------------------------------------------------------------------------
// <auto-generated>
//     This file was generated by the C# SDK Code Generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Scripting;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Unity.Services.CloudSave.Internal.Http;



namespace Unity.Services.CloudSave.Internal.Models
{
    /// <summary>
    /// SetItemBatchResponse model
    /// </summary>
    [Preserve]
    [DataContract(Name = "SetItemBatchResponse")]
    internal class SetItemBatchResponse
    {
        /// <summary>
        /// Creates an instance of SetItemBatchResponse.
        /// </summary>
        /// <param name="results">results param</param>
        [Preserve]
        public SetItemBatchResponse(List<SetItemBatchResponseResults> results = default)
        {
            Results = results;
        }

        /// <summary>
        /// Parameter results of SetItemBatchResponse
        /// </summary>
        [Preserve]
        [DataMember(Name = "results", EmitDefaultValue = false)]
        public List<SetItemBatchResponseResults> Results{ get; }
    
        /// <summary>
        /// Formats a SetItemBatchResponse into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            if (Results != null)
            {
                serializedModel += "results," + Results.ToString();
            }
            return serializedModel;
        }

        /// <summary>
        /// Returns a SetItemBatchResponse as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            return dictionary;
        }
    }
}
