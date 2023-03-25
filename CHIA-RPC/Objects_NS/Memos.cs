using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Objects_NS
{
    /// <summary>
    /// a memo is of type string and might be attached to a <see cref="Transaction"/>
    /// </summary>
    public class Memos : ObjectTemplate<Memos>
    {
        public string memo { get; set; }
    }
}
