using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Datalayer_NS
{
    /// <summary>
    /// Represents a cancel_offer RPC request.
    /// </summary>
    /// <remarks><see href="https://docs.chia.net/datalayer-rpc/#cancel_offer"/></remarks>
    /// <returns><see cref="General_NS.Success_Response"/></returns>
    public class CancelOffer_RPC : RPCTemplate<CancelOffer_RPC>
    {
        /// <summary>
        /// parameterless constructor, for serializer
        /// </summary>
        public CancelOffer_RPC() { /* required for json serialisation */ }
        /// <summary>
        /// Cancel a DataLayer offer
        /// </summary>
        /// <param name="trade_id">The trade_id of the offer. This is displayed with the response of the make_offer RPC</param>
        /// <param name="secure">If true, the offer will be canceled on the blockchain, making it impossible to be accepted later.
        /// If false, the offer will only be canceled locally. We recommend that you set this to true unless you are certain that the offer file has not left your computer</param>
        /// <param name="fee">If secure is true, this will set the fee for the transaction, in mojos. If secure is false, the fee will be ignored</param>
        public CancelOffer_RPC(string trade_id, bool secure, ulong? fee = null)
        {
            this.trade_id = trade_id;
            this.secure = secure;
            this.fee = fee;
        }

        /// <summary>
        /// The trade ID of the offer. This is displayed with the response of the make_offer RPC.
        /// </summary>
        /// <remarks>mandatory</remarks>
        public string? trade_id { get; set; }

        /// <summary>
        /// If true, the offer will be canceled on the blockchain, making it impossible to be accepted later.
        /// If false, the offer will only be canceled locally. We recommend that you set this to true unless
        /// you are certain that the offer file has not left your computer.
        /// </summary>
        /// <remarks>mandatory</remarks>
        public bool secure { get; set; }

        /// <summary>
        /// If secure is true, this will set the fee for the transaction, in mojos. 
        /// If secure is false, the fee will be ignored.
        /// </summary>
        /// <remarks>optional</remarks>
        public ulong? fee { get; set; }
    }
}

