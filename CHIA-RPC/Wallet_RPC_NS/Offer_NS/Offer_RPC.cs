using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Wallet_RPC_NS.Offer_NS
{
    /// <summary>
    /// Creates a new offer.
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/offer-rpc#create_offer_for_ids"/>
    /// </remarks>
    /// <returns><see cref="Objects_NS.OfferFile"/></returns>
    public class Offer_RPC : RPCTemplate<Offer_RPC>
    {
        /// <summary>
        /// this dictionary contains your requested additions and substractions, in mojos.<br/>
        /// if you wan to offer an nft for example, use the launcher id such as <br/>
        /// "1": 1000000000000 (offer for 1 xch) <br/>
        /// "cc4138f8debe4fbedf26ccae0f965be19c67a49d525f1416c0749c3c865dxxx", -1 <br/>
        /// </summary>
        public Dictionary<string, long> offer { get; set; }

        /// <summary>
        /// An optional fee (in mojos) to include with the offer. Defaults to 0.
        /// </summary>
        public ulong? fee { get; set; } = 0;

        /// <summary>
        /// Defaults to False. Set to True to verify the validity of a potential offer, rather than actually creating an offer.
        /// </summary>
        public bool? validate_only { get; set; } = false;

        /// <summary>
        /// A dictionary [str, Any] containing metadata of the asset being requested, for example an NFT's on-chain metadata
        /// </summary>
        public Dictionary<string, object>? driver_dict { get; set; }

        /// <summary>
        /// The minimum coin size to be included in the offer [Default: 0]
        /// </summary>
        public ulong? min_coin_amount { get; set; } = 0;

        /// <summary>
        /// The maximum coin size to be included in the offer [Default: 0]
        /// </summary>
        public ulong? max_coin_amount { get; set; } = 0;

        /// <summary>
        /// Default: None
        /// </summary>
        public List<KeyValuePair<string, object>>? solver { get; set; }
        public static Offer_RPC GenerateOffer_RPC(Nft[] sells, Nft[] buys, long mojoValue)
        {

            Offer_RPC offer_rpc = new Offer_RPC();
            foreach (Nft sell in sells)
            {
                //offer_rpc.offer.Add(sell.launcher_id, -1);
                offer_rpc.offer.Add(sell.launcher_id, -1);
            }
            foreach (Nft buy in buys)
            {
                //offer_rpc.offer.Add(buy.launcher_id, 1);
                offer_rpc.offer.Add(buy.launcher_id, 1);
            }
            // offer_rpc.offer.Add("1", mojoValue);
            offer_rpc.offer.Add("1", mojoValue);
            return offer_rpc;
        }
    }
}
