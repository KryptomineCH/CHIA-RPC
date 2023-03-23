using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_RPC_NS.NFT_NS
{
    /// <summary>
    /// Set the transaction status of an NFT
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/nft-rpc#nft_set_nft_status"/></remarks>
    /// <returns><see cref="General_NS.Success_Response"/></returns>
    public class NftSetNftStatus_RPC : RPCTemplate<NftSetNftStatus_RPC>
    {
        /// <summary>
        /// The ID of an NFT wallet
        /// </summary>
        public ulong wallet_id { get; set; }

        /// <summary>
        /// The coin_id of the NFT on which to set the status
        /// </summary>
        /// <remarks>
        /// eg: 
        /// </remarks>
        public string coin_id { get; set; }

        /// <summary>
        /// A boolean to set the transaction status for the NFT
        /// </summary>
        public bool in_transaction { get; set; }
    }
}
