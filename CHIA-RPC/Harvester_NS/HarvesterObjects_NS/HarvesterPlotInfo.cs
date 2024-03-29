﻿using CHIA_RPC.HelperFunctions_NS;
using System.Text.Json.Serialization;

namespace CHIA_RPC.Harvester_NS.HarvesterObjects_NS
{
    /// <summary>
    /// contains info about a specific plot in the harvester
    /// </summary>
    public class HarvesterPlotInfo : ObjectTemplate<HarvesterPlotInfo>
    {
        /// <summary>
        /// thes plots filesize in bytes
        /// </summary>
        public ulong? file_size { get; set; }
        /// <summary>
        /// the filename of the plotfile
        /// </summary>
        public string? filename { get; set; }
        /// <summary>
        /// the plots unique identifier
        /// </summary>
        public string? plot_id { get; set; }
        /// <summary>
        /// the plots public key
        /// </summary>
        public string? plot_public_key { get; set; }
        /// <summary>
        /// the pools contract ? puzzhash which the plot belongs to
        /// </summary>
        public string? pool_contract_puzzle_hash { get; set; }
        /// <summary>
        /// The public key of the pool
        /// </summary>
        public string? pool_public_key { get; set; }
        /// <summary>
        /// the k size of the plot (difficulty related)
        /// </summary>
        public ulong? size { get; set; }
        /// <summary>
        /// the last time when this plot was modified in unix time
        /// </summary>
        public ulong? time_modified { get; set; }
        /// <summary>
        /// The time_modified as DateTime.
        /// </summary>
        [JsonIgnore]
        public DateTime? time_modified_dateTime
        {
            get
            {
                if (time_modified.HasValue)
                {
                    DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds((long)time_modified.Value);
                    return dateTimeOffset.DateTime;
                }
                return null;
            }
        }
    }
}
