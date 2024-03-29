﻿using CHIA_RPC.HelperFunctions_NS;
using System.Text.Json.Serialization;

namespace CHIA_RPC.Datalayer_NS.DatalayerObjects_NS
{
    /// <summary>
    /// Represents a root hash and timestamp
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/datalayer-rpc#get_root"/> <br/>
    /// <seealso href="https://docs.chia.net/datalayer-rpc#get_roots"/>
    /// </remarks>
    public class RootHash : ObjectTemplate<RootHash>
    {
        /// <summary>
        /// Whether or not the hash is confirmed
        /// </summary>
        public bool? confirmed { get; set; }

        /// <summary>
        /// The root hash
        /// </summary>
        public string? root_hash { get; set; }
        /// <summary>
        /// The root hash
        /// </summary>
        public string? hash { get; set; }

        /// <summary>
        /// The store ID
        /// </summary>
        public string? id { get; set; }

        /// <summary>
        /// The timestamp as unix time
        /// </summary>
        public ulong? timestamp { get; set; }
        /// <summary>
        /// The timestamp as DateTime.
        /// </summary>
        [JsonIgnore]
        public DateTime? timestamp_dateTime
        {
            get
            {
                if (timestamp.HasValue)
                {
                    DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds((long)timestamp.Value);
                    return dateTimeOffset.DateTime;
                }
                return null;
            }
        }
    }
}
