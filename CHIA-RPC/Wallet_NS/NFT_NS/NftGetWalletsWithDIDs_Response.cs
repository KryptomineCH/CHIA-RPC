using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Wallet_NS.NFT_NS
{
    /// <summary>
    /// NftGetWalletsWithDIDs_Response is a data transfer object that is used to hold the response of the "nft_get_wallets_with_dids" RPC call.
    /// This response contains a list of NFT (Non-Fungible Token) wallets that are associated with Decentralized Identifiers (DIDs). 
    /// A DID is a new type of identifier that is globally unique, resolvable with high availability, and cryptographically verifiable.
    /// They are used for digital identity in the context of self-sovereign identity.
    /// </summary>
    /// <remarks>
    /// RPC documentation: <see href="https://docs.chia.net/nft-rpc#nft_get_wallets_with_dids"/><br/><br/>
    /// This RPC request doesn't require any parameters. It's meant to retrieve information about all NFT wallets in the system that have an associated DID.
    /// This can be useful for querying and managing NFT assets within a Chia network environment.
    /// Each entry in the returned array represents an NFT wallet that has an associated DID. 
    /// </remarks>
    public class NftGetWalletsWithDIDs_Response : ResponseTemplate<NftGetWalletsWithDIDs_Response>
    {
        /// <summary>
        /// A list of NFT wallets that are associated with a DID. Each NftWallet object represents an individual NFT wallet, containing information about the wallet itself and its associated DID.
        /// </summary>
        public NftWallet[]? nft_wallets { get; set; }
    }
}
