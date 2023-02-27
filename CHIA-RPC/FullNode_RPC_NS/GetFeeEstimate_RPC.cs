using CHIA_RPC.Objects_NS;
using System.Text;
using System.Text.Json;

namespace CHIA_RPC.FullNode_RPC_NS
{
    public class GetFeeEstimate_Response
    {
        public ulong CurrentFeeRate { get; set; }
        public ulong[] Estimates { get; set; }
        public bool FullNodeSynced { get; set; }
        public ulong LastPeakTimestamp { get; set; }
        public ulong MempoolMaxSize { get; set; }
        public ulong MempoolSize { get; set; }
        public ulong NodeTimeUTC { get; set; }
        public ulong PeakHeight { get; set; }
        public bool Success { get; set; }
        public ulong[] TargetTimes { get; set; }
    }
    /// <summary>
    /// Retrieves the info about the net space (total space allocated by farmers)
    /// </summary>
    public class GetFeeEstimate_RPC
    {
        /// <summary>
        /// the start header hash
        /// </summary>
        public string spend_bundle { get; set; }
        /// <summary>
        /// the end header hash
        /// </summary>
        public ulong cost { get; set; }
        public ulong[] target_times { get; set; }

        /// <summary>
        /// saves the rpc as rpc-file (json) to the specified path
        /// </summary>
        /// <param name="path"></param>
        public void Save(string path)
        {
            if (!path.EndsWith(".rpc"))
            {
                path += ".rpc";
            }
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;
            options.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;
            string testText = JsonSerializer.Serialize(this, options: options);
            Encoding utf8WithoutBom = new UTF8Encoding(false); // no bom
            File.WriteAllText(path, testText, utf8WithoutBom);
        }
        /// <summary>
        /// loads an rpc file from the specified path
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static GetNetworkSpace_Rpc Load(string path)
        {
            FileInfo testFile = new FileInfo(path);
            string text = File.ReadAllText(testFile.FullName);
            GetNetworkSpace_Rpc rpc = JsonSerializer.Deserialize<GetNetworkSpace_Rpc>(text);
            return rpc;
        }
        /// <summary>
        /// serializes this object into a json string
        /// </summary>
        /// <returns>json formatted string</returns>
        public override string ToString()
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = false;
            options.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;
            string jsonString = JsonSerializer.Serialize(this, options: options);
            return jsonString;
        }
    }
}
