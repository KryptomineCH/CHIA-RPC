﻿using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Datalayer_NS
{
    /// <summary>
    /// Get all keys and values for a store. Must be subscribed to store ID
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/datalayer-rpc/#get_keys_values"/><br/><br/>
    /// Uses:<br/><see cref="GetKeys_RPC"/>
    /// </remarks>
    public class GetKeysValues_Response : ResponseTemplate<GetKeysValues_Response>
    {
        /// <summary>
        /// all available keyvaluepairs
        /// </summary>
        public DataStoreKeyValuePair[]? keys_values { get; set; }
        /// <summary>
        /// Converts the GetKeysValues_Response object to a Dictionary with hex-encoded keys and values.
        /// </summary>
        /// <returns>A Dictionary with hex-encoded keys and values.</returns>
        public Dictionary<string, string> ToDictionary()
        {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();

            if (keys_values != null)
            {
                foreach (DataStoreKeyValuePair kvp in keys_values)
                {
                    if (kvp.value == null)
                    {
                        throw new NullReferenceException(nameof(kvp));
                    }
                    string? key = kvp.key;
                    if (string.IsNullOrEmpty(key))
                    {
                        throw new NullReferenceException(nameof(key));
                    }
                    if (key.StartsWith("0x")) key = key.Substring(2);
                    keyValuePairs.Add(key, kvp.value);
                }
            }

            return keyValuePairs;
        }
        /// <summary>
        /// Implicit conversion operator from GetKeysValues_Response to Dictionary.
        /// </summary>
        /// <param name="response">The GetKeysValues_Response object to be converted.</param>
        /// <returns>A Dictionary with hex-encoded keys and values.</returns>
        public static implicit operator Dictionary<string, string>(GetKeysValues_Response response)
        {
            return response.ToDictionary();
        }
    }
    /// <summary>
    /// a key and value for a store. Must be subscribed to store ID
    /// </summary>
    ///  <remarks><see href="https://docs.chia.net/datalayer-rpc/#get_keys_values"/></remarks>
    public class DataStoreKeyValuePair : ObjectTemplate<DataStoreKeyValuePair>
    {
        /// <summary>
        /// Represents an 'atom' in the Chia space. This is a fundamental unit of data within a specific store, which can hold various types of data and participate in complex data structures.
        /// </summary>
        /// <value>
        /// An object that can be of any data type, depending on the specific use-case in the Chia space.
        /// </value>
        public object? atom { get; set; }
        /// <summary>
        /// validation hash sum
        /// </summary>
        public string? hash { get; set; }
        /// <summary>
        /// the hex encoded key (unique identifier) of this keyvaluepair
        /// </summary>
        public string? key { get; set; }
        /// <summary>
        /// the hex encoded value of this keyvaluepair
        /// </summary>
        public string? value { get; set; }
    }
}
