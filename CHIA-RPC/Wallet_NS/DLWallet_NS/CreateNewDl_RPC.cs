using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;

namespace CHIA_RPC.Wallet_NS.DLWallet_NS
{
    /// <summary>
    /// Represents a response from the Create a new DataLayer wallet API call.
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/wallet-rpc#create_new_dl"/><br/><br/>
    /// Uses:<br/><see cref="CreateNewDL_RPC"/>
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
        public Transaction_DictMemos[] transactions { get; set; }
    }
    /// <summary>
    /// Create a new DataLayer wallet
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/wallet-rpc#create_new_dl"/></remarks>
    /// <returns><see cref="CreateNewDL_Response"/></returns>
    public class CreateNewDL_RPC : RPCTemplate<CreateNewDL_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public CreateNewDL_RPC() { /* for serialisation */ }
        /// <summary>
        /// Create a new DataLayer wallet
        /// </summary>
        /// <param name="root">The root hash of an existing data store</param>
        /// <param name="fee">An optional blockchain fee, in mojos</param>
        public CreateNewDL_RPC(string root, ulong? fee = null)
        {
            this.root = root;
            this.fee = fee;
        }

        /// <summary>
        /// The root hash of an existing data store
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string root { get; set; }

        /// <summary>
        /// An optional blockchain fee, in mojos
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? fee { get; set; }
    }

}
