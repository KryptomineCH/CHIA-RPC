using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.General_NS
{
    /// <summary>
    /// used for a wide variety of lookup and selection operations
    /// </summary>
    public class Index_Response : ResponseTemplate<Index_Response>
    {
        /// <summary>
        /// index is a common value used for data lookups
        /// </summary>
        public ulong index { get; set; }
    }
    /// <summary>
    /// used for a wide variety of lookup and selection operations
    /// </summary>
    public class Index_RPC : RPCTemplate<Index_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public Index_RPC() { /* for serialisation */ }
        /// <summary>
        /// used for a wide variety of lookup and selection operations
        /// </summary>
        /// <param name="index">index is a common value used for data lookups</param>
        public Index_RPC(ulong index)
        {
            this.index = index;
        }
        /// <summary>
        /// used for a wide variety of lookup and selection operations
        /// </summary>
        /// <param name="response">index is a common value used for data lookups</param>
        public Index_RPC(Index_Response response)
        {
            this.index = response.index;
        }

        /// <summary>
        /// index is a common value used for data lookups
        /// </summary>
        /// <remarks>mandatory</remarks>
        public ulong index { get; set; }
        /// <summary>
        /// Implicit conversion from Index_Response to Index_RPC.
        /// </summary>
        /// <param name="response">Index_RPC object</param>
        public static implicit operator Index_RPC(Index_Response response)
        {
            return new Index_RPC(response);
        }
    }
}
