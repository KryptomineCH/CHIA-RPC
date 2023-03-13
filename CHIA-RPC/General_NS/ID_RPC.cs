using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.General_NS
{
    public class ID_RPC : RPCTemplate<ID_RPC>
    {
        public string id { get; set; }
        /// <summary>
        /// note: this value may only be used for requests which trigger a transaction on the blockchain
        /// </summary>
        public ulong? fee { get; set; }
    }
}
