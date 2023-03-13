﻿using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Datalayer_NS
{
    /// <summary>
    /// Represents a cancel_offer RPC request.
    /// </summary>
    public class CancelOffer_RPC : RPCTemplate<CancelOffer_RPC>
    {
        /// <summary>
        /// The trade ID of the offer. This is displayed with the response of the make_offer RPC.
        /// </summary>
        public string trade_id { get; set; }

        /// <summary>
        /// If true, the offer will be canceled on the blockchain, making it impossible to be accepted later.
        /// If false, the offer will only be canceled locally. We recommend that you set this to true unless
        /// you are certain that the offer file has not left your computer.
        /// </summary>
        public bool secure { get; set; }

        /// <summary>
        /// If secure is true, this will set the fee for the transaction, in mojos. If secure is false,
        /// the fee will be ignored.
        /// </summary>
        public ulong? fee { get; set; }
    }
}
