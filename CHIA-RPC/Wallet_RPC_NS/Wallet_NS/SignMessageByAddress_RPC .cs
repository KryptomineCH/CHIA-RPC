using CHIA_RPC.HelperFunctions_NS;
namespace CHIA_RPC.Wallet_RPC_NS.Wallet_NS
{
    /// <summary>
    /// The sign_message_by_address function is useful for creating a digital signature of a message using a specific XCH address, without having to create an on-chain transaction. <br/>
    /// The digital signature can then be shared with other parties, who can verify the authenticity of the message and confirm that it was signed by the owner of the provided XCH address. 
    /// This is done without having to broadcast a transaction to the blockchain, which makes the process faster and more cost-effective compared to on-chain transactions.
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/wallet-rpc/#sign_message_by_address"/><br/><br/>
    /// Uses:<br/><see cref="SignMessageByAddress_RPC"/>
    /// </remarks>
    public class SignMessage_Response : ResponseTemplate<SignMessage_Response>
    {
        public string pubkey { get; set; }
        public string signature { get; set; }
    }
    /// <summary>
    /// The sign_message_by_address function is useful for creating a digital signature of a message using a specific XCH address, without having to create an on-chain transaction. <br/>
    /// The digital signature can then be shared with other parties, who can verify the authenticity of the message and confirm that it was signed by the owner of the provided XCH address. 
    /// This is done without having to broadcast a transaction to the blockchain, which makes the process faster and more cost-effective compared to on-chain transactions.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc/#sign_message_by_address"/></remarks>
    /// <returns><see cref="SignMessage_Response"/></returns>
    public class SignMessageByAddress_RPC : RPCTemplate<SignMessageByAddress_RPC>
    {
        /// <summary>
        /// The address to use for signing.Must possess the key for this address
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string address { get; set; }
        /// <summary>
        /// The message to include with the signature
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string message { get; set; }
    }
}
