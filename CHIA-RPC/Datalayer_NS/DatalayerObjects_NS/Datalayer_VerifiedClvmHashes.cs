using CHIA_RPC.HelperFunctions_NS;
namespace CHIA_RPC.Datalayer_NS.DatalayerObjects_NS
{
    ///<remarks>
    /// <see href="https://docs.chia.net/datalayer-rpc/#verify_proof"/><br/><br/>
    /// Uses:<br/><see cref="VerifyProof_RPC"/>
    /// </remarks>
    public class Datalayer_VerifiedClvmHashes : ObjectTemplate<Datalayer_VerifiedClvmHashes>
    {
        public Datalayer_KvInclusion[] inclusions { get; set; }
        public string store_id { get; set; }
    }
}
