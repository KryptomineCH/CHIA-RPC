﻿using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;
using System.Text.Json.Serialization;

namespace CHIA_RPC.Wallet_NS.DID_NS
{
    /// <summary>
    /// Response class for the did_get_current_coin_info API method
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/did-rpc#did_get_current_coin_info"/><br/><br/>
    /// uses:<br/> <see cref="General_NS.WalletID_RPC"/>
    /// </remarks>
    public class DidGetCurrentCoinInfo_Response : ResponseTemplate<DidGetCurrentCoinInfo_Response>
    {
        /// <summary>
        /// DID amount
        /// </summary>
        public ulong? did_amount { get; set; }
        /// <summary>
        /// the did amount in xch
        /// </summary>
        /// <remarks>This value is derived from the mojos amount</remarks>
        [JsonIgnore]
        public decimal? did_amount_in_xch
        {
            get { return did_amount / GlobalVar.OneChiaInMojos; }
            set { did_amount = (ulong?)(value * GlobalVar.OneChiaInMojos); }
        }

        /// <summary>
        /// DID inner puzzle hash
        /// </summary>
        public string? did_innerpuz { get; set; }

        /// <summary>
        /// DID parent coin
        /// </summary>
        public string? did_parent { get; set; }

        /// <summary>
        /// My DID
        /// </summary>
        public string? my_did { get; set; }

        /// <summary>
        /// Wallet ID
        /// </summary>
        public ulong? wallet_id { get; set; }
    }

}
