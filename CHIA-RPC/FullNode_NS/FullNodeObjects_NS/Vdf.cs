using CHIA_RPC.HelperFunctions_NS;
using System.Buffers.Text;
using System.Diagnostics;
using System.Xml;

namespace CHIA_RPC.FullNode_NS.FullNodeObjects_NS
{
    /// <summary>
    /// Vdf is a Verifiable Delay Function, a cryptographic primitive that provides a proof that a certain amount of time has passed since a specific event or input. <br/>
    /// The main property of a VDF is that it takes a predetermined amount of time to compute, but once computed, the output can be quickly verified by others. <br/>
    /// VDFs are useful in various decentralized systems, particularly in blockchain and distributed ledger technologies, to ensure fair ordering of events, prevent certain attacks like grinding attacks, and maintain the integrity and security of the network.
    /// <br/><br/>
    /// Here's a brief overview of how a VDF works:<br/>
    /// Input: A VDF takes an input value, often referred to as a "seed" or "challenge."
    /// <br/><br/>
    /// Computation: The VDF requires a certain amount of time(measured in sequential steps) to compute the output based on the input.
    /// This time is usually predetermined and fixed for a specific implementation of the VDF. 
    /// The computation process is deliberately slow and sequential, meaning that it cannot be significantly sped up through parallelization or other optimization techniques.
    /// <br/><br/>
    /// Output: Once the VDF computation is completed, it produces an output value, also known as the "proof" or "solution." 
    /// This output value is uniquely determined by the input and the required computation time.
    /// <br/><br/>
    /// Verification: The key property of a VDF is that, although the computation process is slow, the output can be quickly verified by others.
    /// This verification process is significantly faster than the computation itself, ensuring that once the output is produced, it can be easily confirmed as correct by other parties in the network.
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/full-node-rpc#get_block"/><br/>
    /// <see href="https://docs.chia.net/full-node-rpc#get_blocks"/><br/>
    /// <see href="https://docs.chia.net/full-node-rpc#get_recent_signage_point_or_eos"/>
    /// </remarks>
    public class Vdf : ObjectTemplate<Vdf>
    {
        public string challenge { get; set; }
        public ulong number_of_iterations { get; set; }
        public OutputData output { get; set; }

        public class OutputData : ObjectTemplate<OutputData>
        {
            public string data { get; set; }
        }
    }
}
