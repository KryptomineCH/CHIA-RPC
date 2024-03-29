﻿
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Objects_NS
{
    /// <summary>
    /// represents a keyvaluepair required for serialisation
    /// </summary>
    public class KeyValueString : ObjectTemplate<KeyValueString>
    {
        /// <summary>
        /// the key of the keyvaluepair
        /// </summary>
        public string? key { get; set; }

        /// <summary>
        /// the value of the keyvaluepair
        /// </summary>
        public string? value { get; set; }
    }
}
