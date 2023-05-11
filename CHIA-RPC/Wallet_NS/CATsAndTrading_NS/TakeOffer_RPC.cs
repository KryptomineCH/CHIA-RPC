
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.CATsAndTrading_NS
{
    /// <summary>
    /// Represents a TakeOffer_RPC class that inherits from RPCTemplate.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc/#take_offer"/></remarks>
    /// <returns><see cref="General_NS.TradeRecord_Response"/></returns>
    public class TakeCatOffer_RPC : RPCTemplate<TakeCatOffer_RPC>
    {
        /// <summary>
        /// Gets or sets the offer to create.
        /// </summary>
        public string offer { get; set; }

        /// <summary>
        /// Gets or sets the minimum coin amount to select for taking the offer.
        /// Default: none
        /// </summary>
        public ulong? min_coin_amount { get; set; }

        /// <summary>
        /// Gets or sets the maximum coin amount to select for taking the offer.
        /// Default: none
        /// </summary>
        public ulong? max_coin_amount { get; set; }

        /// <summary>
        /// Gets or sets a marshalled solver.
        /// </summary>
        public string solver { get; set; }

        /// <summary>
        /// Gets or sets an optional blockchain fee, in mojos.
        /// </summary>
        public ulong? fee { get; set; }

        /// <summary>
        ///  If `true`, will not generate a new puzzle hash / address for this transaction only. 
        ///  Note that setting this parameter to `true` will override the global default setting from config.yaml
        /// </summary>
        /// <remarks>optional</remarks>
        public bool? reuse_puzhash { get; set; }
    }
}
