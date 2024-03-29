﻿namespace CHIA_RPC.Datalayer_NS.DatalayerObjects_NS
{
    /// <summary>
    /// represents a proof on the datalayer
    /// </summary>
    public class Datalayer_Proof
    {
        /// <summary>
        /// Represents the key.
        /// </summary>
        public string? key { get; set; }

        /// <summary>
        /// Represents the layers details.
        /// </summary>
        public Layer[]? layers { get; set; }

        /// <summary>
        /// Represents the node hash.
        /// </summary>
        public string? node_hash { get; set; }

        /// <summary>
        /// Represents the value.
        /// </summary>
        public string? value { get; set; }
        /// <summary>
        /// Represents the details of a layer.
        /// </summary>
        public class Layer
        {
            /// <summary>
            /// Represents the combined hash.
            /// </summary>
            public string? combined_hash { get; set; }

            /// <summary>
            /// Represents the other hash.
            /// </summary>
            public string? other_hash { get; set; }

            /// <summary>
            /// Represents the other hash side.
            /// </summary>
            public string? other_hash_side { get; set; }
        }
    }
}
