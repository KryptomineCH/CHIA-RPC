using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Wallet_RPC_NS.Wallet_NS
{
    public class Offer_RPC : RPCTemplate<Offer_RPC>
    {
        /// <summary>
        /// this dictionary contains your requested additions ans substractions, in mojos.<br/>
        /// if you wan to offer an nft for example, use the launcher id such as <br/>
        /// "1": 1000000000000 (offer for 1 xch) <br/>
        /// "cc4138f8debe4fbedf26ccae0f965be19c67a49d525f1416c0749c3c865dxxx", -1 <br/>
        /// 
        /// </summary>
        public Dictionary<string, long> offer { get; set; } = new Dictionary<string, long>();

        public ulong? fee { get; set; }

        public bool? validate_only { get; set; }

        public dynamic? driver_dict { get; set; }

        public ulong? min_coin_amount { get; set; }

        public ulong? max_coin_amount { get; set; }

        public List<KeyValuePair<string, object>>? solver { get; set; }
        public static Offer_RPC GenerateOffer_RPC(Nft[] sells, Nft[] buys, long mojoValue )
        {
        
            Offer_RPC offer_rpc = new Offer_RPC();
            foreach ( Nft sell in sells )
            {
                //offer_rpc.offer.Add(sell.launcher_id, -1);
                offer_rpc.offer.Add(sell.launcher_id, -1);
            }
            foreach ( Nft buy in buys )
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
