using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.NFT_NS
{
    /// <summary>
    /// Set the transaction status of an NFT
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/nft-rpc#nft_set_nft_status"/></remarks>
    /// <returns><see cref="General_NS.Success_Response"/></returns>
    public class NftSetNftStatus_RPC : RPCTemplate<NftSetNftStatus_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public NftSetNftStatus_RPC() { /* for serialisation */ }
        /// <summary>
        /// Set the transaction status of an NFT
        /// </summary>
        /// <param name="wallet_id">The ID of an NFT wallet</param>
        /// <param name="coin_id">The coin_id of the NFT on which to set the status</param>
        /// <param name="in_transaction">A boolean to set the transaction status for the NFT</param>
        public NftSetNftStatus_RPC(ulong wallet_id, string coin_id, bool in_transaction)
        {
            this.wallet_id = wallet_id;
            this.coin_id = coin_id;
            this.in_transaction = in_transaction;
        }

        /// <summary>
        /// The ID of an NFT wallet
        /// </summary>
        public ulong? wallet_id { get; set; }

        /// <summary>
        /// The coin_id of the NFT on which to set the status
        /// </summary>
        /// <remarks>
        /// eg: 
        /// </remarks>
        public string? coin_id { get; set; }

        /// <summary>
        /// A boolean to set the transaction status for the NFT
        /// </summary>
        public bool? in_transaction { get; set; }
    }
}
