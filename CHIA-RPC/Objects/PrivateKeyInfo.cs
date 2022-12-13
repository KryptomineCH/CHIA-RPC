namespace CHIA_RPC.Objects
{
    public class PrivateKeyInfo
    {
        public string farmer_pk { get; set; }
        /// <summary>
        /// the wallet figer print
        /// </summary>
        public ulong fingerprint { get; set; }
        public string pk { get; set; }
        public string pool_pk { get; set; }
        /// <summary>
        /// the 24 word mnemonic seed
        /// </summary>
        public string seed { get; set; }
        public string sk { get; set; }
    }
}
