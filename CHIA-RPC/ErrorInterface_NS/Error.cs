using CHIA_RPC.Daemon_NS.Server_NS;
using CHIA_RPC.General_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.ErrorInterface_NS
{
    public class Error
    {
        public Error(string objectJson, string objectName, string errorDescription, string function)
        {
            RpcVersion = GlobalVar.PackageVersion;
            ErrorTime = DateTime.Now;
            ObjectName = objectName;
            ErrorDescription = errorDescription;
            Function = function;
            ObjectJson = objectJson;
        }
        public Version RpcVersion { get; set; }
        public DateTime ErrorTime { get; set; }
        public string ObjectName { get; set; }
        public string ErrorDescription { get; set; }
        public string Function { get; set; }
        public string ObjectJson { get; set; }
    }
}
