using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Objects_NS
{
    /// <summary>
    /// Contains info about the keys of a Wallet.
    /// WARNING this is Private and should never be shared!
    /// </summary>
    public class PrivateKeyInfo : ObjectTemplate<PrivateKeyInfo>
    {
        /// <summary>
        /// the public key of the farmer
        /// </summary>
        public string? farmer_pk { get; set; }
        /// <summary>
        /// the wallet figer print
        /// </summary>
        public ulong? fingerprint { get; set; }
        /// <summary>
        /// the public key of the wallet
        /// </summary>
        public string? pk { get; set; }
        /// <summary>
        /// the public key of the pool
        /// </summary>
        public string? pool_pk { get; set; }
        /// <summary>
        /// the 24 word mnemonic seed
        /// </summary>
        public string? seed { get; set; }
        /// <summary>
        /// The private key associated with this wallet.
        /// This is highly sensitive data - if someone else gains access to this, they have full control over the wallet.
        /// </summary>
        public string? sk { get; set; }
    }
}
