
namespace CHIA_RPC.HelperFunctions_NS
{
    public static class ByteConversions
    {
        /// <summary>
        /// Decodes a Chia address into its puzzle hash.
        /// </summary>
        /// <param name="address">The Chia address to decode.</param>
        /// <returns>The decoded puzzle hash as a byte array.</returns>
        /// <exception cref="ArgumentException">Thrown when the provided address is not valid.</exception>
        public static byte[] DecodePuzzleHash(string address)
        {
            var puzzleHash = Bech32M.AddressToPuzzleHash(address);
            if (puzzleHash == null || puzzleHash.Bytes.Length != 32)
            {
                throw new ArgumentException("Invalid Address", nameof(address));
            }

            return puzzleHash.Bytes; // Assuming HexBytes has a Bytes property that returns a byte array
        }
    }
}
