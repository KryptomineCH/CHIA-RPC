﻿using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Datalayer_NS.DatalayerObjects_NS
{
    /// <summary>
    /// Represents a mirror object.
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/datalayer-rpc#get_mirrors"/>
    /// </remarks>
    public class Mirror : ObjectTemplate<Mirror>
    {
        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        public ulong amount { get; set; }

        /// <summary>
        /// Gets or sets the coin ID.
        /// </summary>
        public string coin_id { get; set; }

        /// <summary>
        /// Gets or sets the launcher ID.
        /// </summary>
        public string launcher_id { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this mirror is ours.
        /// </summary>
        public bool ours { get; set; }

        /// <summary>
        /// Gets or sets the URLs.
        /// </summary>
        public string[] urls { get; set; }
    }
}