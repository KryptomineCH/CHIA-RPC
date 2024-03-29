﻿using CHIA_RPC.HelperFunctions_NS;
using System.Text.Json.Serialization;

namespace CHIA_RPC.Objects_NS
{
    public class OfferSummary : ObjectTemplate<OfferSummary>
    {
        /// <summary>
        /// The fees associated with the transaction.
        /// </summary>
        public ulong fees { get; set; }

        /// <summary>
        /// Information about each item involved in the transaction.
        /// The key is a unique identifier, and the value contains details about the item.
        /// </summary>
        public Dictionary<string, AssetInfo> infos { get; set; }

        /// <summary>
        /// Details of what is being offered in the transaction.
        /// Key represents the currency type, and the value is the amount.
        /// </summary>
        public Dictionary<string, ulong> offered { get; set; }

        /// <summary>
        /// Details of what is requested in the transaction.
        /// Key represents the unique identifier of the item, and the value is the amount requested.
        /// </summary>
        public Dictionary<string, ulong> requested { get; set; }

        /// <summary>
        /// custom function checking if this offer will generate a separate fee transaction for the person accepting the offer
        /// </summary>
        /// <remarks>
        /// unknown behaviour, when you create the offer with an attached fee.
        /// </remarks>
        [JsonIgnore]
        public bool contains_separate_fee_trasaction 
        { 
            get
            {
                if (fees == 0 || !requested.ContainsKey("xch")) return false;
                return true;
            }
        }

        /// <summary>
        /// Represents the information of a single item in the transaction.
        /// </summary>
        public class Info
        {
            /// <summary>
            /// Unique identifier of the item.
            /// </summary>
            public string tail { get; set; }

            /// <summary>
            /// Type of the item.
            /// </summary>
            public string type { get; set; }
        }
    }
}