﻿using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_RPC_NS.DID_NS
{
    /// <summary>
    /// Represents the response object for the did_find_lost_did RPC command.
    /// </summary>
    public class DidFindLostDidResponse : ResponseTemplate<DidFindLostDidResponse>
    {
        /// <summary>
        /// The latest coin ID of the recovered DID wallet.
        /// </summary>
        public string latest_coin_id { get; set; }
    }

    /// <summary>
    /// RPC request for recovering a missing or unspendable DID wallet by submitting a coin id of the DID
    /// </summary>
    public class DidFindLostDid_RPC : RPCTemplate<DidFindLostDid_RPC>
    {
        /// <summary>
        /// The DID ID, launcher ID, or latest coin ID of the DID you want to recover. The most time-efficient of these is the latest coin ID.
        /// </summary>
        public string coin_id { get; set; }
    }
}