﻿using CHIA_RPC.HelperFunctions_NS;
using CHIA_RPC.Objects_NS;
using System.Text;

namespace CHIA_RPC.Datalayer_NS.DatalayerObjects_NS
{
    /// <summary>
    /// The Maker offers to include a new key exchange for the Taker including a new key. A few things to keep in mind:OfferFile_Datalayer
    /// <list type="bullet">
    /// <item>Offers for multiple keys are also possible</item>
    /// <item>Typically the Maker should not offer keys that have already been included because the Taker will have no incentive to accept the offer. (In making an offer, the Maker is essentially saying, "I'll include these keys if you agree to include these other keys.")</item>
    /// <item>The fee is an optional transaction fee that will go to a farmer</item>
    /// </list>
    /// </summary>
    /// <remarks>
    /// <see href="https://docs.chia.net/datalayer-rpc/#take_offer"/> <br/>
    /// <seealso href="https://docs.chia.net/datalayer-rpc/#make_offer"/>
    /// </remarks>
    public class OfferFile_Datalayer : ObjectTemplate<OfferFile_Datalayer>
    {
        /// <summary>
        /// Represents the maker details.
        /// </summary>
        public OfferFile_Datalayer_Maker[] maker { get; set; }

        /// <summary>
        /// Represents the offer id.
        /// </summary>
        public string offer { get; set; }

        /// <summary>
        /// Represents the taker details.
        /// </summary>
        public OfferFile_Datalayer_Taker[] taker { get; set; }

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
    public class OfferFile_Datalayer_Maker
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
    public class OfferFile_Datalayer_Taker
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