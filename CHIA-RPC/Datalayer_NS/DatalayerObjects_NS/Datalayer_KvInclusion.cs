﻿using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Datalayer_NS.DatalayerObjects_NS
{
    ///<remarks>
    /// <see href="https://docs.chia.net/datalayer-rpc/#verify_proof"/><br/><br/>
    /// Uses:<br/><see cref="VerifyProof_RPC"/>
    /// </remarks>
    public class Datalayer_KvInclusion : ObjectTemplate<Datalayer_KvInclusion>
    {
        public string key_clvm_hash { get; set; }
        public string value_clvm_hash { get; set; }
    }
}
