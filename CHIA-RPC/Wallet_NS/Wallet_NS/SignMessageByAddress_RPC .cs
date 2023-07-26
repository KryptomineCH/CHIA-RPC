using CHIA_RPC.HelperFunctions_NS;
namespace CHIA_RPC.Wallet_NS.Wallet_NS
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
        /// <summary>
        /// The `pubkey` property refers to the public key associated with the XCH address used to sign the message. 
        /// The public key is derived from the private key of the XCH address and it is used to verify the digital signature of a message. 
        /// It does not reveal any sensitive information and can be safely shared with others. 
        /// </summary>
        public string? pubkey { get; set; }

        /// <summary>
        /// The `signature` property contains the digital signature of the message. The digital signature is created by 
        /// using the private key associated with the XCH address. This process guarantees that the message was signed 
        /// by the owner of the XCH address, as the signature can be verified using the associated public key. 
        /// The digital signature is unique for every message, meaning that even a small change in the message will result in a different signature. 
        /// It is safe to share the digital signature with others as it does not reveal any sensitive information. 
        /// </summary>
        public string? signature { get; set; }

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
        /// parameterless constructor, for serializer
        /// </summary>
        public SignMessageByAddress_RPC() { /* for serialisation */ }
        /// <summary>
        /// The sign_message_by_address function is useful for creating a digital signature of a message using a specific XCH address, without having to create an on-chain transaction.
        /// </summary>
        /// <param name="address">The address to use for signing.Must possess the key for this address</param>
        /// <param name="message">The message to include with the signature</param>
        public SignMessageByAddress_RPC(string address, string message)
        {
            this.address = address;
            this.message = message;
        }

        /// <summary>
        /// The address to use for signing.Must possess the key for this address
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string? address { get; set; }
        /// <summary>
        /// The message to include with the signature
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string? message { get; set; }
    }
}
