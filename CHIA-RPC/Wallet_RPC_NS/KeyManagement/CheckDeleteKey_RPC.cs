﻿using System.ComponentModel.DataAnnotations;

namespace CHIA_RPC.Wallet_RPC_NS.KeyManagement
{
    public class CheckDeleteKey_Response
    {
        /// <summary>
        /// The wallet's fingerprint, obtainable by running chia wallet show
        /// </summary>
        public ulong fingerprint { get; set; }
        /// <summary>
        /// farm rewards go to this wallet
        /// </summary>
        public bool used_for_farmer_rewards { get; set; }
        /// <summary>
        /// pool rewards go to this wallet
        /// </summary>
        public bool used_for_pool_rewards { get; set; }
        /// <summary>
        /// wallet still contains a balance
        /// </summary>
        public bool wallet_balance { get; set; }
        public bool success { get; set; }
        public string error { get; set; }
    }
    public class CheckDeleteKey_RPC
    {
        /// <summary>
        /// The wallet's fingerprint, obtainable by running chia wallet show
        /// </summary>
        /// <remarks>mandatory</remarks>
        [Required]
        public ulong fingerprint { get; set; }
        /// <summary>
        /// The maximum number of puzzle hashes to search [Default: 100]
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong max_ph_to_search { get; set; }
    }
}
