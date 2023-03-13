using CHIA_RPC.HelperFunctions_NS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHIA_RPC.Wallet_RPC_NS.Offer_NS
{
    /// <summary>
    /// Checks whether a specific offer is valid.
    /// </summary>
    public class CheckOfferValidity_RPC : RPCTemplate<CheckOfferValidity_RPC>
    {
        /// <summary>
        /// The offer to check. The offer is considered valid if it is in any of the following states:
        /// PENDING_ACCEPT
        /// PENDING_CONFIRM
        /// PENDING_CANCEL
        /// The offer is no longer valid if it is in any of the following states:
        /// CANCELLED
        /// CONFIRMED
        /// FAILED
        /// </summary>
        public string[] offer { get; set; }
    }
}
