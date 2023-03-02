using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Objects_NS
{
    public class NftWallet : ObjectTemplate<NftWallet>
    {
        /// <summary>
        /// the digital identity associated with the nft wallet
        /// </summary>
        public string did_id { get; set; }
        /// <summary>
        /// the wallet id of the did wallet
        /// </summary>
        public ulong did_wallet_id { get; set; }
        /// <summary>
        /// the wallet id of the nft wallet
        /// </summary>
        public ulong wallet_id { get; set; }
    }
}
