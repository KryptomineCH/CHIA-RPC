﻿using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Farmer_NS
{
    /// <summary>
    /// Set the payout instructions parameter for your pool configuration.
    /// </summary>
    /// <remarks>Request returns a success response</remarks>
    public class SetPayoutInstructions_RPC : RPCTemplate<SetPayoutInstructions_RPC>
    {
        /// <summary>
        /// The launcher_id from your pool, obtainable from the get_pool_state RPC.
        /// </summary>
        public string launcher_id { get; set; }

        /// <summary>
        /// The puzzle hash to be used as the new payout_instructions.
        /// </summary>
        public string payout_instructions { get; set; }
    }
}
