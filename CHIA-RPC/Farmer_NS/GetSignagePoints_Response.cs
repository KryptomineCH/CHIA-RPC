using CHIA_RPC.Farmer_NS.FarmerObjects_NS;
using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Farmer_NS
{
    /// <summary>
    /// List details for all signage points going back several challenges
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/farmer-rpc#get_signage_points"/><br/><br/>
    /// Uses:<br/>the request has no parameters
    /// </remarks>
    public class GetSignagePoints_Response : ResponseTemplate<GetSignagePoints_Response>
    {
        /// <summary>
        /// an array of all signage points
        /// </summary>
        public SignagepointInfo[]? signage_points { get; set;}
        /// <summary>
        /// This class encapsulates information related to signage points in the blockchain. Signage points 
        /// are crucial for the proof-of-space-and-time (PoST) consensus mechanism used in Chia, as they 
        /// dictate when and how often proofs can be submitted to the network.
        /// </summary>
        public class SignagepointInfo : ObjectTemplate<SignagepointInfo>
        {
            /// <summary>
            /// This is an array of Proof objects related to the Signage Point. Each proof contains specific 
            /// details about the plotted space that satisfies the conditions set by a given signage point.
            /// The proofs are proof-of-space submissions that can be used to compete for the right to add blocks 
            /// to the blockchain. More proofs equate to more chances to win farming rewards, as they represent 
            /// legitimate space that has been allocated for farming.
            /// </summary>
            public Proof[]? proofs { get; set; }

            /// <summary>
            /// This property represents a signage point associated with this instance of `SignagepointInfo`.
            /// Signage points are part of the Chia Network's consensus mechanism and are used to facilitate 
            /// the process of submitting proofs to the network. Signage points occur periodically and represent 
            /// opportunities for farmers to submit their proofs of space.
            /// </summary>
            public SignagePoint? signage_point { get; set; }
        }

    }
}
