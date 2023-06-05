using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.General_NS
{
    /// <summary>
    /// represents a unique identifier wallet which can be uset to authenticate against other parties
    /// </summary>
    public class DidID_Response : ResponseTemplate<DidID_Response>
    {
        /// <summary>
        /// eg:<br/>
        /// did:chia:1kzxqrt8f2h8psr8zuzen9dxgmxx5v35s0rj3jy637qjannu3zlesds0el5
        /// </summary>
        public string did_id { get; set; }

    }
    /// <summary>
    /// represents a unique identifier wallet which can be uset to authenticate against other parties
    /// </summary>
    public class DidID_RPC : RPCTemplate<DidID_RPC>
    {
        /// <summary>
        /// for serializer
        /// </summary>
        public DidID_RPC() { /* for serialisation */ }
        /// <summary>
        /// represents a unique identifier wallet which can be uset to authenticate against other parties
        /// </summary>
        /// <param name="did_id">The Wallet ID of the wallet from which to obtain the balance</param>
        public DidID_RPC(string did_id)
        {
            this.did_id = did_id;
        }
        /// <summary>
        /// represents a unique identifier wallet which can be uset to authenticate against other parties
        /// </summary>
        /// <param name="did_id">The Wallet ID of the wallet from which to obtain the balance</param>
        public DidID_RPC(DidID_Response did_id)
        {
            this.did_id = did_id.did_id;
        }

        /// <summary>
        /// The Wallet ID of the wallet from which to obtain the balance
        /// </summary>
        /// <remarks>eg:<br/>
        /// did:chia:1kzxqrt8f2h8psr8zuzen9dxgmxx5v35s0rj3jy637qjannu3zlesds0el5
        /// </remarks>
        public string did_id { get; set; }

        /// <summary>
        /// Implicit conversion from DidID_Response to DidID_RPC.
        /// </summary>
        /// <param name="response">DidID_Response object</param>
        public static implicit operator DidID_RPC(DidID_Response response)
        {
            return new DidID_RPC(response.did_id);
        }
    }
}
