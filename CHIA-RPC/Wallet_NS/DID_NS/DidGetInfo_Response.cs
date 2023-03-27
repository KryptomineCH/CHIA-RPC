﻿using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.DID_NS
{
    /// <summary>
    /// Response class for the did_get_info RPC.
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/did-rpc#did_get_info"/><br/><br/>
    /// Uses:<br/><see cref="DidGetInfo_RPC"/>
    /// </remarks>
    public class DidGetInfo_Response : ResponseTemplate<DidGetInfo_Response>
    {
        /// <summary>
        /// The full puzzle of the DID wallet.
        /// </summary>
        public string full_puzzle { get; set; }

        /// <summary>
        /// List of hints for the DID wallet.
        /// </summary>
        public string[] hints { get; set; }

        /// <summary>
        /// Latest coin of the DID wallet.
        /// </summary>
        public string latest_coin { get; set; }

        /// <summary>
        /// ID of the launcher for the DID wallet.
        /// </summary>
        public string launcher_id { get; set; }

        /// <summary>
        /// Metadata for the DID wallet.
        /// </summary>
        public Dictionary<string, object> metadata { get; set; }

        /// <summary>
        /// The number of verifications for the DID wallet.
        /// </summary>
        public ulong num_verification { get; set; }

        /// <summary>
        /// The P2 address of the DID wallet.
        /// </summary>
        public string p2_address { get; set; }

        /// <summary>
        /// The public key of the DID wallet.
        /// </summary>
        public string public_key { get; set; }

        /// <summary>
        /// The recovery list hash of the DID wallet.
        /// </summary>
        public string recovery_list_hash { get; set; }
    }

    /// <summary>
    /// Response class for the did_get_info RPC.
    /// </summary>
    /// <remarks> <see href="https://docs.chia.net/did-rpc#did_get_info"/></remarks>
    /// <returns><see cref="DidGetInfo_Response"/></returns>
    public class DidGetInfo_RPC : RPCTemplate<DidGetInfo_RPC>
    {
        /// <summary>
        /// the coin id to look up
        /// </summary>
        public string coin_id { get; set; }
    }
}