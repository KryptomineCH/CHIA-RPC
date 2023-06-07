using System.ComponentModel.DataAnnotations;
using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Wallet_NS.DID_NS
{
    /// <summary>
    /// Recover a DID to a new DID by using an attest file
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/did-rpc#did_recovery_spend"/></remarks>
    /// <returns><see cref="General_NS.SpendBundle_Response"/></returns>
    public class DidRecoverySpend_RPC : RPCTemplate<DidRecoverySpend_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public DidRecoverySpend_RPC() { /* for serialisation */ }

        /// <summary>
        /// Recover a DID to a new DID by using an attest file
        /// </summary>
        /// <param name="wallet_id">The Wallet ID of the DID wallet to recover</param>
        /// <param name="attest_data">A list of attest files to be used for recovery</param>
        /// <param name="pubkey">The public key of the wallet to recover. If this is not provided, a temporary public key will be used instead</param>
        /// <param name="puzhash">The puzzle hash of the wallet to recover. If this is not provided, a temporary puzzle hash will be used instead</param>
        /// <param name="fee">An optional blockchain fee, in mojos</param>
        public DidRecoverySpend_RPC(ulong wallet_id, string[] attest_data, string? pubkey, string? puzhash, ulong? fee)
        {
            this.wallet_id = wallet_id;
            this.attest_data = attest_data;
            this.pubkey = pubkey;
            this.puzhash = puzhash;
            this.fee = fee;
        }
        /// <summary>
        /// Recover a DID to a new DID by using an attest file
        /// </summary>
        /// <param name="wallet_id">The Wallet ID of the DID wallet to recover</param>
        /// <param name="attest_data">A list of attest files to be used for recovery</param>
        /// <param name="pubkey">The public key of the wallet to recover. If this is not provided, a temporary public key will be used instead</param>
        /// <param name="puzhash">The puzzle hash of the wallet to recover. If this is not provided, a temporary puzzle hash will be used instead</param>
        /// <param name="fee">An optional blockchain fee, in mojos</param>
        public DidRecoverySpend_RPC(WalletID_RPC wallet_id, string[] attest_data, string? pubkey, string? puzhash, ulong? fee)
        {
            this.wallet_id = wallet_id.wallet_id;
            this.attest_data = attest_data;
            this.pubkey = pubkey;
            this.puzhash = puzhash;
            this.fee = fee;
        }
        /// <summary>
        /// Recover a DID to a new DID by using an attest file
        /// </summary>
        /// <param name="wallet_id">The Wallet ID of the DID wallet to recover</param>
        /// <param name="attest_data">A list of attest files to be used for recovery</param>
        /// <param name="pubkey">The public key of the wallet to recover. If this is not provided, a temporary public key will be used instead</param>
        /// <param name="puzhash">The puzzle hash of the wallet to recover. If this is not provided, a temporary puzzle hash will be used instead</param>
        /// <param name="fee">An optional blockchain fee, in mojos</param>
        public DidRecoverySpend_RPC(WalletID_Response wallet_id, string[] attest_data, string? pubkey, string? puzhash, ulong? fee)
        {
            this.wallet_id = wallet_id.wallet_id;
            this.attest_data = attest_data;
            this.pubkey = pubkey;
            this.puzhash = puzhash;
            this.fee = fee;
        }


        /// <summary>
        /// The Wallet ID of the DID wallet to recover
        /// </summary>
        /// <remarks>mandatory</remarks>
        public ulong wallet_id { get; set; }
        /// <summary>
        /// A list of attest files to be used for recovery
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string[] attest_data { get; set; }
        /// <summary>
        /// The public key of the wallet to recover. If this is not provided, a temporary public key will be used instead
        /// </summary>
        /// <remarks>optional</remarks>
        public string? pubkey { get; set; }
        /// <summary>
        /// The puzzle hash of the wallet to recover. If this is not provided, a temporary puzzle hash will be used instead
        /// </summary>
        /// <remarks>optional</remarks>
        public string? puzhash { get; set; }
        /// <summary>
        /// An optional blockchain fee, in mojos
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? fee { get; set; }
    }
}
