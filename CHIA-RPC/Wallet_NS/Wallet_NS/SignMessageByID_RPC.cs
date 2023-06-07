using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.Wallet_NS
{
    /// <summary>
    /// The sign_message_by_id function is used to sign a message using a Decentralized Identifier (DID) or Non-Fungible Token (NFT) ID, without creating an on-chain transaction. 
    /// This can be useful in various situations, such as proving ownership of a DID or NFT, securing communications, or creating non-repudiable proofs for off-chain agreements involving DIDs or NFTs.<br/>
    /// The digital signature can then be shared with other parties, who can verify the authenticity of the message and confirm that it was signed by the owner of the provided DID or NFT ID. 
    /// This is done without having to broadcast a transaction to the blockchain, which makes the process faster and more cost-effective compared to on-chain transactions.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc/#sign_message_by_id"/></remarks>
    /// <returns><see cref="SignMessage_Response"/></returns>
    public class SignMessageByID_RPC : RPCTemplate<SignMessageByID_RPC>
    {   
        /// <summary>
        /// parameterless Constructor, for serializer
        /// </summary>
        public SignMessageByID_RPC() { /* for serialisation */ }
        /// <summary>
        ///  The sign_message_by_id function is used to sign a message using a Decentralized Identifier (DID) or Non-Fungible Token (NFT) ID, without creating an on-chain transaction. 
        /// </summary>
        /// <param name="id">The address to use for signing.Must possess the key for this address</param>
        /// <param name="message">The message to include with the signature</param>
        public SignMessageByID_RPC(string id, string message)
        {
            this.id = id;
            this.message = message;
        }

        /// <summary>
        /// The address to use for signing.Must possess the key for this address
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string id { get; set; }
        /// <summary>
        /// The message to include with the signature
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string message { get; set; }
    }
}
