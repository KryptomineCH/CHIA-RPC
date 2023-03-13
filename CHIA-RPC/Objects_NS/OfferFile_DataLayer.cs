using CHIA_RPC.HelperFunctions_NS;
using System.Text;

namespace CHIA_RPC.Objects_NS
{
	public class OfferFile_DataLayer : ObjectTemplate<OfferFile_DataLayer>
    {
        /// <summary>
        /// Represents the maker details.
        /// </summary>
        public OfferFile_DataLayer_Maker[] maker { get; set; }

        /// <summary>
        /// Represents the offer id.
        /// </summary>
        public string offer { get; set; }

        /// <summary>
        /// Represents the taker details.
        /// </summary>
        public OfferFile_DataLayer_Taker[] taker { get; set; }

        /// <summary>
        /// Represents the trade id.
        /// </summary>
        public string trade_id { get; set; }
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
    }
    /// <summary>
    /// Represents the details of a maker.
    /// </summary>
    public class OfferFile_DataLayer_Maker
    {
        /// <summary>
        /// Represents the proofs details.
        /// </summary>
        public Proof[] proofs { get; set; }

        /// <summary>
        /// Represents the store id.
        /// </summary>
        public string store_id { get; set; }
    }
    /// <summary>
    /// Represents the details of a taker.
    /// </summary>
    public class OfferFile_DataLayer_Taker
    {
        /// <summary>
        /// Represents the inclusions details.
        /// </summary>
        public Inclusion[] inclusions { get; set; }

        /// <summary>
        /// Represents the store id.
        /// </summary>
        public string store_id { get; set; }
        /// <summary>
        /// Represents the details of an inclusion.
        /// </summary>
        public class Inclusion
        {
            /// <summary>
            /// Represents the key.
            /// </summary>
            public string key { get; set; }

            /// <summary>
            /// Represents the value.
            /// </summary>
            public string value { get; set; }
        }
    }
}
