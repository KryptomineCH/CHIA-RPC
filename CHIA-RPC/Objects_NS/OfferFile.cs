using System.Text;
using System.Text.Json;

namespace CHIA_RPC.Objects_NS
{
	public class OfferFile
	{
		public string offer { get; set; }
		public TradeRecord trade_record { get; set;}
	
		public bool success { get; set; }
		public string? error { get; set; }
        /// <summary>
        /// saves the offer as rpc-file (json) to the specified path which can be reimported
        /// </summary>
        /// <param name="path"></param>
        public void Save(string path)
        {
            if (!path.EndsWith(".offer.json"))
            {
                path += ".offer";
            }
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;
            options.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;
            string testText = JsonSerializer.Serialize(this, options: options);
            Encoding utf8WithoutBom = new UTF8Encoding(false); // no bom
            File.WriteAllText(path, testText, utf8WithoutBom);
        }
        /// <summary>
        /// exports the offer as offer file which can be uploaded to exchanges
        /// </summary>
        /// <param name="path"></param>
        public void Export(string path)
        {
            if (!path.EndsWith(".offer"))
            {
                path += ".offer";
            }
            Encoding utf8WithoutBom = new UTF8Encoding(false); // no bom
            File.WriteAllText(path, offer, utf8WithoutBom);
        }
        /// <summary>
        /// loads an rpc file from the specified path
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static OfferFile Load(string path)
        {
            if (!path.EndsWith(".offer.json"))
            {
                path += ".offer";
            }
            FileInfo testFile = new FileInfo(path);
            string text = File.ReadAllText(testFile.FullName);
            OfferFile rpc = JsonSerializer.Deserialize<OfferFile>(text);
            return rpc;
        }
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
