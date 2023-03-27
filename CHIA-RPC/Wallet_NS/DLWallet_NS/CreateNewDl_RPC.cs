using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Wallet_NS.DLWallet_NS
{
    /// <summary>
    /// Represents a response from the Create a new DataLayer wallet API call.
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/wallet-rpc#create_new_dl"/><br/><br/>
    /// Uses:<br/><see cref="CreateNewDl_RPC"/>
    /// </remarks>
    public class CreateNewDL_Response : ResponseTemplate<CreateNewDL_Response>
    {
        /// <summary>
        /// The launcher ID of the created wallet.
        /// </summary>
        public string launcher_id { get; set; }

        /// <summary>
        /// The list of transactions associated with the wallet.
        /// </summary>
        public Transaction[] transactions { get; set; }
    }
    /// <summary>
    /// Create a new DataLayer wallet
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc#create_new_dl"/></remarks>
    /// <returns><see cref="CreateNewDL_Response"/></returns>
    public class CreateNewDl_RPC : RPCTemplate<CreateNewDl_RPC>
    {
        /// <summary>
        /// The root hash of an existing data store
        /// </summary>
        public string root { get; set; }

        /// <summary>
        /// An optional blockchain fee, in mojos
        /// </summary>
        public ulong? fee { get; set; }
    }

}
