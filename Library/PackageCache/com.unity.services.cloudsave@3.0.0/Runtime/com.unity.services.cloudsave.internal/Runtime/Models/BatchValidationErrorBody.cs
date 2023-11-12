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
    /// Single error in the Batch Validation Error Response.
    /// </summary>
    [Preserve]
    [DataContract(Name = "BatchValidationErrorBody")]
    internal class BatchValidationErrorBody
    {
        /// <summary>
        /// Single error in the Batch Validation Error Response.
        /// </summary>
        /// <param name="field">field param</param>
        /// <param name="messages">messages param</param>
        /// <param name="key">key param</param>
        [Preserve]
        public BatchValidationErrorBody(string field, List<string> messages, string key)
        {
            Field = field;
            Messages = messages;
            Key = key;
        }

        /// <summary>
        /// Parameter field of BatchValidationErrorBody
        /// </summary>
        [Preserve]
        [DataMember(Name = "field", IsRequired = true, EmitDefaultValue = true)]
        public string Field{ get; }
        
        /// <summary>
        /// Parameter messages of BatchValidationErrorBody
        /// </summary>
        [Preserve]
        [DataMember(Name = "messages", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Messages{ get; }
        
        /// <summary>
        /// Parameter key of BatchValidationErrorBody
        /// </summary>
        [Preserve]
        [DataMember(Name = "key", IsRequired = true, EmitDefaultValue = true)]
        public string Key{ get; }
    
        /// <summary>
        /// Formats a BatchValidationErrorBody into a string of key-value pairs for use as a path parameter.
        /// </summary>
        /// <returns>Returns a string representation of the key-value pairs.</returns>
        internal string SerializeAsPathParam()
        {
            var serializedModel = "";

            if (Field != null)
            {
                serializedModel += "field," + Field + ",";
            }
            if (Messages != null)
            {
                serializedModel += "messages," + Messages.ToString() + ",";
            }
            if (Key != null)
            {
                serializedModel += "key," + Key;
            }
            return serializedModel;
        }

        /// <summary>
        /// Returns a BatchValidationErrorBody as a dictionary of key-value pairs for use as a query parameter.
        /// </summary>
        /// <returns>Returns a dictionary of string key-value pairs.</returns>
        internal Dictionary<string, string> GetAsQueryParam()
        {
            var dictionary = new Dictionary<string, string>();

            if (Field != null)
            {
                var fieldStringValue = Field.ToString();
                dictionary.Add("field", fieldStringValue);
            }
            
            if (Messages != null)
            {
                var messagesStringValue = Messages.ToString();
                dictionary.Add("messages", messagesStringValue);
            }
            
            if (Key != null)
            {
                var keyStringValue = Key.ToString();
                dictionary.Add("key", keyStringValue);
            }
            
            return dictionary;
        }
    }
}
