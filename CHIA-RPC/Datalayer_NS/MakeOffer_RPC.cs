using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.DataLayer_NS
{
    /// <summary>
    /// Make an offer to include one or more keys in exchange for a Taker including one or more keys
    /// </summary>
    /// <remarks>request returns a OfferFile_DataLayer</remarks>
    public class MakeOffer_RPC : RPCTemplate<MakeOffer_RPC>
    {
        /// <summary>
        /// The hexadecimal ID of the store for which to list mirrors
        /// </summary>
        public DealParticipant[] maker { get; set; }

        /// <summary>
        /// The hexadecimal ID of the store for which to list mirrors
        /// </summary>
        public DealParticipant[] taker { get; set; }

        /// <summary>
        /// Set the fee for the offer, in mojos
        /// </summary
        /// <remarks>optional</remarks>
        public ulong? fee { get; set; }

        /// <summary>
        /// The maker's data
        /// </summary>
        public class DealParticipant
        {
            /// <summary>
            /// The hexadecimal store ID
            /// </summary>
            public string store_id { get; set; }

            /// <summary>
            /// The list of key-value pairs
            /// </summary>
            public Dictionary<string, string> inclusions { get; set; }
        }
    }
}
