﻿
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Objects_NS
{
    public class CoinTransaction : ObjectTemplate<CoinTransaction>
    {
        /// <summary>
        /// The coin information
        /// </summary>
        public Coin coin { get; set; }

        /// <summary>
        /// Indicates whether the coin is a farmer or pool reward, paid for by the blockchain
        /// </summary>
        public bool coinbase { get; set; }

        /// <summary>
        /// The block height of confirmation
        /// </summary>
        public int confirmed_block_index { get; set; }

        /// <summary>
        /// Indicates whether the coin is spent
        /// </summary>
        public bool spent { get; set; }

        /// <summary>
        /// The block height where the coin was spent
        /// </summary>
        public int spent_block_index { get; set; }

        /// <summary>
        /// The timestamp of the block where the coin was created
        /// </summary>
        public int timestamp { get; set; }
    }
}