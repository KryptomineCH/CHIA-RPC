using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.General_NS
{
    public class DidID_Response : ResponseTemplate<DidID_Response>
    {
        /// <summary>
        /// eg:<br/>
        /// did:chia:1kzxqrt8f2h8psr8zuzen9dxgmxx5v35s0rj3jy637qjannu3zlesds0el5
        /// </summary>
        public string did_id { get; set; }
    }
    public class DidID_RPC : RPCTemplate<DidID_RPC>
    {
        /// <summary>
        /// The Wallet ID of the wallet from which to obtain the balance
        /// </summary>
        /// <remarks>eg:<br/>
        /// did:chia:1kzxqrt8f2h8psr8zuzen9dxgmxx5v35s0rj3jy637qjannu3zlesds0el5
        /// </remarks>
        public string did_id { get; set; }
    }
}
