using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.FullNode_NS.FullNodeObjects_NS
{
    /// <summary>
    /// This class represents a Proof of Space (PoSpace), a cryptographic concept 
    /// used in the Chia blockchain to prove that a certain amount of disk storage 
    /// space has been allocated. It is a type of 'proof of resource' used instead 
    /// of proof of work in the Chia cryptocurrency. This class provides the 
    /// necessary parameters for a PoSpace, such as challenge, plot_public_key, 
    /// pool_contract_puzzle_hash, pool_public_key, proof, and size.
    /// </summary>
    /// <remarks>
    /// For more information, see the following Chia RPC API references: 
    /// - <see href="https://docs.chia.net/full-node-rpc#get_block"/> for getting block details.
    /// - <see href="https://docs.chia.net/full-node-rpc#get_blocks"/> for getting multiple blocks.
    /// </remarks>
    public class ProofOfSpace : ObjectTemplate<ProofOfSpace>
    {
        /// <summary>
        /// Represents the challenge string for the Proof of Space. 
        /// This is a hash value that the prover must use to generate their proof.
        /// </summary>
        public string? challenge { get; set; }

        /// <summary>
        /// The public key of the plot for which the Proof of Space is being provided.
        /// </summary>
        public string? plot_public_key { get; set; }

        /// <summary>
        /// Represents the puzzle hash of the pool contract. 
        /// This is related to pooling protocol in Chia and is applicable when the plot is part of a pool.
        /// </summary>
        public string? pool_contract_puzzle_hash { get; set; }

        /// <summary>
        /// The public key of the pool for which the Proof of Space is being provided.
        /// </summary>
        public object? pool_public_key { get; set; }

        /// <summary>
        /// The actual proof string for the Proof of Space.
        /// </summary>
        public string? proof { get; set; }

        /// <summary>
        /// The size of the plot for which the Proof of Space is being provided, 
        /// generally measured in kibibytes (KiB).
        /// </summary>
        public ulong? size { get; set; }
    }

}
