using CHIA_RPC.HelperFunctions_NS;
using System.Collections.Concurrent;
using System.Reflection.Metadata.Ecma335;
using System.Text.Json.Serialization;

namespace CHIA_RPC.Objects_NS
{
    /// <summary>
    /// thread safe implementation of a offers chunk file.<br/>
    /// Default size: max 1000 Blocks (~1GB if all offers were to be saved and filled)
    /// </summary>
    /// <remarks>
    /// StartBlock should be 0 Based
    /// eg: 0-999, 1000-1999, 15000-15999
    /// </remarks>
    public class OffersChunk : ObjectTemplate<OffersChunk>
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
        /// calculates the height of the latest offer in this Blockfile
        /// </summary>
        [JsonIgnore]
        public ulong LastOfferBlock
        {
            get
            {
                ulong height = 0;
                foreach (ulong blockHeight in OffersByBlock.Keys)
                {
                    if (blockHeight > height)
                        height = blockHeight;
                }
                return height;
            }
        }

        /// <summary>
        /// specifies if the chunk file has been edited.
        /// This is useful to save changes to disk when removed from a cache
        /// </summary>
        [JsonIgnore]
        public bool Edited { get; set; } = false;

        /// <summary>
        /// holds all offers in the chunkfile.
        /// </summary>
        /// <remarks>
        /// Please add with <see cref="AddOffer"/>, except you want unsafe handling for added performance
        /// </remarks>
        public ConcurrentDictionary<ulong, ConcurrentBag<OfferFile>> OffersByBlock { get; set; } = new ();
        
        /// <summary>
        /// Adds an offer to the Chunkfile
        /// </summary>
        /// <remarks>
        /// verifies the offer is Confirmed and the height was found
        /// </remarks>
        /// <param name="offer">the transaction to add</param>
        /// <exception cref="InvalidOperationException">transaction is not confirmed or height unclear</exception>
        public void AddTransaction(OfferFile offer, bool checkIfConfirmed)
        {
            // pre-add checks
            if (checkIfConfirmed && offer.trade_record.accepted_at_time != null && offer.trade_record.accepted_at_time != 0)
            {
                throw new InvalidOperationException("the transaction is not in status confirmed!"); 
            }
            if (offer.trade_record.confirmed_at_index == null)
            {
                throw new InvalidOperationException("the block of the transaction could not be determined! confirmed_at_height == null");
            }
            // get and check height
            ulong height = offer.trade_record.confirmed_at_index.Value;
            if (height < StartBlock || height > EndBlock)
            {
                throw new InvalidOperationException($"the transaction is at height {height} but the bundle range is {StartBlock}-{EndBlock}");
            }
            // add if block already exists
            if (OffersByBlock.TryGetValue(height, out ConcurrentBag<OfferFile> blockList))
            {
                bool isContained = false;
                foreach (OfferFile offerToCompare in blockList)
                {
                    throw new NotImplementedException("offer comparison not yet implemented!");
                    if (offer == offerToCompare)
                    {
                        
                        isContained = true;
                        break;
                    }
                }
                if(!isContained)
                    blockList.Add(offer);
            }
            // create block if not exists
            else
            {
                OffersByBlock[height] = new ConcurrentBag<OfferFile> { offer };
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
