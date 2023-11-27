using CHIA_RPC.HelperFunctions_NS;
using System.Collections.Concurrent;
using System.Reflection.Metadata.Ecma335;
using System.Text.Json.Serialization;

namespace CHIA_RPC.Objects_NS
{
    /// <summary>
    /// thread safe implementation of a transactions chunk file.<br/>
    /// Default size: max 1000 Blocks (~1GB if all transactions were to be saved and filled)
    /// </summary>
    /// <remarks>
    /// StartBlock should be 0 Based
    /// eg: 0-999, 1000-1999, 15000-15999
    /// </remarks>
    public class TransactionsChunk : ObjectTemplate<TransactionsChunk>
    {
        /// <summary>
        /// The minimum Block height to be included in this chunk file
        /// </summary>
        public ulong StartBlock { get; set; } = 0;

        /// <summary>
        /// The maximum Block height to be included in this chunk file
        /// </summary>
        [JsonIgnore]
        public ulong EndBlock 
        { 
            get
            {
                return StartBlock + ChunkSize - 1;
            }
        }

        /// <summary>
        /// The amount of Blocks this chunk file can hold at maximum
        /// </summary>
        public ulong ChunkSize { get; set; } = 1000;

        /// <summary>
        /// calculates the height of the latest transaction in this Blockfile
        /// </summary>
        [JsonIgnore]
        public ulong LastTransactionBlock
        {
            get
            {
                ulong height = 0;
                foreach (ulong blockHeight in TransactionsByBlock.Keys)
                {
                    if (blockHeight > height)
                        height = blockHeight;
                }
                return height;
            }
        }

        /// <summary>
        /// specifies if the chunk file has been edited. This is useful to save changes to disk when removed from a cache
        /// </summary>
        [JsonIgnore]
        public bool Edited { get; set; } = false;

        /// <summary>
        /// holds all transactions in the chunkfile.
        /// </summary>
        /// <remarks>
        /// Please add with <see cref="AddTransaction"/>, except you want unsafe handling for added performance
        /// </remarks>
        public ConcurrentDictionary<ulong, ConcurrentBag<Transaction_DictMemos>> TransactionsByBlock { get; set; } = new ConcurrentDictionary<ulong, ConcurrentBag<Transaction_DictMemos>> ();
        
        /// <summary>
        /// Adds a transaction to the Chunkfile
        /// </summary>
        /// <remarks>
        /// verifies the transaction is Confirmed and the height was wound
        /// </remarks>
        /// <param name="transaction">the transaction to add</param>
        /// <exception cref="InvalidOperationException">transaction is not confirmed or height unclear</exception>
        public void AddTransaction(Transaction_DictMemos transaction, bool checkIfConfirmed)
        {
            // pre-add checks
            if (checkIfConfirmed && !(bool)transaction.confirmed)
            {
                throw new InvalidOperationException("the transaction is not in status confirmed!"); 
            }
            if (transaction.confirmed_at_height == null)
            {
                throw new InvalidOperationException("the block of the transaction could not be determined! confirmed_at_height == null");
            }
            // get and check height
            ulong height = transaction.confirmed_at_height.Value;
            if (height < StartBlock || height > EndBlock)
            {
                throw new InvalidOperationException($"the transaction is at height {height} but the bundle range is {StartBlock}-{EndBlock}");
            }
            // add if block already exists
            if (TransactionsByBlock.TryGetValue(height, out ConcurrentBag<Transaction_DictMemos> blockList))
            {
                bool isContained = false;
                foreach (Transaction_DictMemos transactionToCompare in blockList)
                {
                    if (transaction == transactionToCompare)
                    {
                        isContained = true;
                        break;
                    }
                }
                if(!isContained)
                    blockList.Add(transaction);
            }
            // create block if not exists
            else
            {
                TransactionsByBlock[height] = new ConcurrentBag<Transaction_DictMemos> { transaction };
            }
            Edited = true;
        }
        /// <summary>
        /// Calculates the starting block number for the chunk containing the specified block.
        /// </summary>
        /// <param name="blockNumber">The block number to find the chunk for.</param>
        /// <returns>The starting block number of the chunk.</returns>
        public ulong CalculateChunkStart(ulong blockNumber)
        {
            return blockNumber - (blockNumber % ChunkSize);
        }
    }
}
