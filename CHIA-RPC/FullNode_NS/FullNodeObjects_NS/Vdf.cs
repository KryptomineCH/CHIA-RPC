using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.FullNode_NS.FullNodeObjects_NS
{
    /// <summary>
    /// Represents a Verifiable Delay Function (VDF), a cryptographic primitive that provides a proof that 
    /// a certain amount of time has elapsed since a specific event or input. VDFs are particularly used in 
    /// blockchain and distributed ledger technologies to ensure fair ordering of events, prevent certain attacks, 
    /// and maintain the integrity and security of the network. This class encapsulates the data fields necessary 
    /// for a VDF instance, including a challenge, number of iterations, and output.
    /// </summary>
    /// <remarks>
    /// For more information, refer to the following Chia RPC API documentation: 
    /// <list type="bullet">
    /// <item><description><see href="https://docs.chia.net/full-node-rpc#get_block"/> for getting block details.</description></item>
    /// <item><description><see href="https://docs.chia.net/full-node-rpc#get_blocks"/> for getting multiple blocks.</description></item>
    /// <item><description><see href="https://docs.chia.net/full-node-rpc#get_recent_signage_point_or_eos"/> for getting recent signage point or end of slot (eos).</description></item>
    /// </list>
    /// </remarks>
    public class Vdf : ObjectTemplate<Vdf>
    {
        /// <summary>
        /// Represents the challenge string for the Verifiable Delay Function. This is the initial input value or seed
        /// that the VDF uses to compute the output.
        /// </summary>
        public string? challenge { get; set; }

        /// <summary>
        /// Represents the number of iterations for the VDF. The computation process of the VDF 
        /// requires a certain number of sequential steps or iterations to compute the output based on the input.
        /// </summary>
        public ulong? number_of_iterations { get; set; }

        /// <summary>
        /// Represents the output data of the VDF computation. The output value or proof is uniquely determined 
        /// by the input and the number of iterations. Although the computation process is slow, this output can 
        /// be quickly verified by others.
        /// </summary>
        public OutputData? output { get; set; }

        /// <summary>
        /// Represents the actual output data from a VDF computation. It contains a data field that 
        /// holds the computed result or proof from the VDF.
        /// </summary>
        public class OutputData : ObjectTemplate<OutputData>
        {
            /// <summary>
            /// The actual proof or solution of the VDF computation.
            /// </summary>
            public string? data { get; set; }
        }
    }

}
