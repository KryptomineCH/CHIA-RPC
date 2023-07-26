using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.DID_NS
{
    /// <summary>
    /// Response class for the did_get_info RPC.
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/did-rpc#did_get_info"/><br/><br/>
    /// Uses:<br/><see cref="DidGetInfo_RPC"/>
    /// </remarks>
    public class DidGetInfo_Response : ResponseTemplate<DidGetInfo_Response>
    {
        /// <summary>
        /// The full puzzle of the DID wallet.
        /// </summary>
        public string? full_puzzle { get; set; }

        /// <summary>
        /// List of hints for the DID wallet.
        /// </summary>
        public string[]? hints { get; set; }

        /// <summary>
        /// Latest coin of the DID wallet.
        /// </summary>
        public string? latest_coin { get; set; }

        /// <summary>
        /// ID of the launcher for the DID wallet.
        /// </summary>
        public string? launcher_id { get; set; }

        /// <summary>
        /// Metadata for the DID wallet.
        /// </summary>
        public Dictionary<string, object>? metadata { get; set; }

        /// <summary>
        /// The number of verifications for the DID wallet.
        /// </summary>
        public ulong? num_verification { get; set; }

        /// <summary>
        /// The P2 address of the DID wallet.
        /// </summary>
        public string? p2_address { get; set; }

        /// <summary>
        /// The public key of the DID wallet.
        /// </summary>
        public string? public_key { get; set; }

        /// <summary>
        /// The recovery list hash of the DID wallet.
        /// </summary>
        public string? recovery_list_hash { get; set; }
    }

    /// <summary>
    /// This class is a representation of a request to get information about a specific coin based on its ID 
    /// in a Distributed Identifier (DID) system. This can be used to look up information about a coin 
    /// such as its current state, its transaction history, etc.
    /// </summary>
    /// <remarks> <see href="https://docs.chia.net/did-rpc#did_get_info"/></remarks>
    /// <returns><see cref="DidGetInfo_Response"/></returns>
    public class DidGetInfo_RPC : RPCTemplate<DidGetInfo_RPC>
    {
        /// <summary>
        /// A parameterless constructor for the <see cref="DidGetInfo_RPC"/> class.
        /// It is required for proper serialization and deserialization of the class.
        /// </summary>
        public DidGetInfo_RPC() { /* for serialisation */ }
        /// <summary>
        /// A constructor for the <see cref="DidGetInfo_RPC"/> class that initializes a new instance with a specified coin ID.
        /// </summary>
        /// <param name="coin_id">The unique identifier of the coin.</param>
        public DidGetInfo_RPC(string coin_id)
        {
            this.coin_id = coin_id;
        }

        /// <summary>
        /// the coin id to look up
        /// </summary>
        public string? coin_id { get; set; }
    }
}
