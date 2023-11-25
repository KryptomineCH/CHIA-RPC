using CHIA_RPC.Daemon_NS.KeychainServer_NS;
using CHIA_RPC.Daemon_NS.KeychainServer_NS.KeychainServerObjects_NS;
using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.General_NS
{
    /// <summary>
    /// contains the fingerprint (unique ID of a wallet)
    /// </summary>
    public class FingerPrint_Response : ResponseTemplate<FingerPrint_Response>
    {
        /// <summary>
        /// The wallet's fingerprint, obtainable by running chia wallet show
        /// </summary>
        public ulong fingerprint { get; set; }
        
    }

    /// <summary>
    /// used for a variety of wallet management and wallet selection tasks
    /// </summary>
    /// <remarks>
    /// an implicit conversion from <see cref="ulong"/> exists<br/>
    /// an implicit conversion from <see cref="FingerPrint_Response"/> exists<br/>
    /// an implicit conversion from <see cref="Key"/> exists<br/>
    /// an implicit conversion from <see cref="GetKey_Response"/> exists<br/>
    /// </remarks>
    public class FingerPrint_RPC : RPCTemplate<FingerPrint_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public FingerPrint_RPC() { /* for serialisation */ }
        /// <summary>
        /// used for a variety of wallet management and wallet selection tasks
        /// </summary>
        /// <param name="fingerprint">The wallet's fingerprint, obtainable by running chia wallet show</param>
        public FingerPrint_RPC(ulong fingerprint)
        {
            this.fingerprint = fingerprint;
        }
        /// <summary>
        /// used for a variety of wallet management and wallet selection tasks
        /// </summary>
        /// <param name="fingerprint">The wallet's fingerprint, obtainable by running chia wallet show</param>
        public FingerPrint_RPC(FingerPrint_Response fingerprint)
        {
            this.fingerprint = fingerprint.fingerprint;
        }
        public FingerPrint_RPC(Key key)
        {
            this.fingerprint = key.fingerprint;
        }
        public FingerPrint_RPC(GetKey_Response keyResponse)
        {
            this.fingerprint = keyResponse.key.fingerprint;
        }

        /// <summary>
        /// The wallet's fingerprint, obtainable by running chia wallet show
        /// </summary>
        public ulong fingerprint { get; set; }
        /// <summary>
        /// Implicit conversion from FingerPrint_Response to DidIFingerPrint_RPCD_RPC.
        /// </summary>
        /// <param name="response">FingerPrint_RPC object</param>
        public static implicit operator FingerPrint_RPC(FingerPrint_Response response)
        {
            return new FingerPrint_RPC(response);
        }
        /// <summary>
        /// converts a key response to a fingerprint explicitly
        /// </summary>
        /// <param name="response"></param>
        public static implicit operator FingerPrint_RPC(Key response)
        {
            return new FingerPrint_RPC(response);
        }
        /// <summary>
        /// converts a GetKey rpc to a fingerprint explicitly
        /// </summary>
        /// <param name="response"></param>
        public static implicit operator FingerPrint_RPC(GetKey_Response response)
        {
            return new FingerPrint_RPC(response);
        }
        /// <summary>
        /// converts an ulong to Fingerprint_RPC implicitly
        /// </summary>
        /// <param name="fingerprint"></param>
        public static implicit operator FingerPrint_RPC(ulong fingerprint)
        {
            return new FingerPrint_RPC(fingerprint);
        }
    }
    /// <summary>
    /// used for a variety of wallet management and wallet selection tasks
    /// </summary>
    /// <remarks>
    /// an implicit conversion from <see cref="Key"/>[] exists<br/>
    /// an implicit conversion from <see cref="GetKeys_Response"/> exists<br/>
    /// an implicit conversion from <see cref="ulong"/>[] exists
    /// </remarks>
    public class FingerPrints_RPC : RPCTemplate<FingerPrints_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public FingerPrints_RPC() { /* for serialisation */ }
        /// <summary>
        /// used for a variety of wallet management and wallet selection tasks
        /// </summary>
        /// <param name="fingerprint">The wallet's fingerprint, obtainable by running chia wallet show</param>
        public FingerPrints_RPC(ulong[] fingerprints)
        {
            this.fingerprints = fingerprints;
        }
        public FingerPrints_RPC(Key[] keys)
        {
            this.fingerprints = new ulong[keys.Length]; 
            for(int i = 0; i < this.fingerprints.Length; i++)
            {
                this.fingerprints[i] = keys[i].fingerprint;
            }
        }
        public FingerPrints_RPC(GetKeys_Response keysResponse)
        {
            this.fingerprints = new ulong[keysResponse.keys.Length];
            for (int i = 0; i < this.fingerprints.Length; i++)
            {
                this.fingerprints[i] = keysResponse.keys[i].fingerprint;
            }
        }

        /// <summary>
        /// used for a variety of wallet management and wallet selection tasks
        /// </summary>
        /// <param name="fingerprint">The wallet's fingerprint, obtainable by running chia wallet show</param>
        public FingerPrints_RPC(FingerPrint_Response[] fingerprints)
        {
            List<ulong> ulongs = new();
            foreach(FingerPrint_Response print in fingerprints) ulongs.Add(print.fingerprint);
            this.fingerprints = ulongs.ToArray();
        }

        /// <summary>
        /// The wallet's fingerprint, obtainable by running chia wallet show
        /// </summary>
        public ulong[] fingerprints { get; set; }
        /// <summary>
        /// Implicit conversion from FingerPrint_Response to FingerPrint_RPC.
        /// </summary>
        /// <param name="response">FingerPrint_RPC object</param>
        public static implicit operator FingerPrints_RPC(FingerPrint_Response[] response)
        {
            return new FingerPrints_RPC(response);
        }
        /// <summary>
        /// Implicit conversion from Keyresponse to FingerPrint_RPC.
        /// </summary>
        /// <param name="response">FingerPrint_RPC object</param>
        public static implicit operator FingerPrints_RPC(Key[] response)
        {
            return new FingerPrints_RPC(response);
        }
        /// <summary>
        /// Implicit conversion from GetKeys_Response to FingerPrint_RPC.
        /// </summary>
        /// <param name="response">FingerPrint_RPC object</param>
        public static implicit operator FingerPrints_RPC(GetKeys_Response response)
        {
            return new FingerPrints_RPC(response);
        }
    }
}
