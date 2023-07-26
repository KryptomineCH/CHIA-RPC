using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.FullNode_NS.FullNodeObjects_NS
{
    /// <summary>
    /// This class encapsulates the VDF (Verifiable Delay Function) output of a challenge in the Chia blockchain.
    /// </summary>
    /// <remarks>
    /// In the context of Chia blockchain, a challenge is a process that is initiated as part of the Proof-of-Space and Proof-of-Time protocols. 
    /// The output of the VDF is a deterministic, unique response that proves a certain amount of time has elapsed since the challenge was issued.
    /// <br/>
    /// For more details, see: <see href="https://docs.chia.net/full-node-rpc#get_blockchain_state"/>
    /// </remarks>
    public class ChallengeVdfOutput : ObjectTemplate<ChallengeVdfOutput>
    {
        /// <summary>
        /// The VDF output data from a challenge in the blockchain.
        /// </summary>
        /// <remarks>
        /// This data is the output from the verifiable delay function (VDF) operation on a challenge. 
        /// The VDF requires a certain amount of real-time to compute, but can be verified quickly. 
        /// This property represents the proof that the required time delay has been observed in response to a challenge.
        /// </remarks>
        public string? data { get; set; }
    }

}
