using CHIA_RPC.HelperFunctions_NS;
using System.Text.Json.Serialization;

namespace CHIA_RPC.Wallet_NS.Offer_NS.OfferObjects_NS
{
    /// <summary>
    /// Represents the valid time constraints for an entity.
    /// </summary>
    public class ValidTimes : ObjectTemplate<ValidTimes>
    {
        /// <summary>
        /// The maximum block height where the entity is still considered valid. [Default: <c>null</c> (not used)]
        /// </summary>
        public ulong? max_height { get; set; }

        /// <summary>
        /// The maximum UNIX timestamp where the entity is still considered valid. [Default: <c>null</c> (not used)]
        /// </summary>
        public ulong? max_time { get; set; }

        /// <summary>
        /// The minimum block height that must be reached before the entity becomes valid. [Default: <c>null</c> (not used)]
        /// </summary>
        public ulong? min_height { get; set; }

        /// <summary>
        /// The minimum UNIX timestamp that must be reached before the entity becomes valid. [Default: <c>null</c> (not used)]
        /// </summary>
        public ulong? min_time { get; set; }

        /// <summary>
        /// Gets or sets the maximum time as a DateTime? object. Converts to and from UNIX time.
        /// </summary>
        [JsonIgnore]
        public DateTime? max_time_DateTime
        {
            get
            {
                if (max_time.HasValue)
                {
                    DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds((long)max_time.Value);
                    return dateTimeOffset.DateTime;
                }
                return null;
            }
            set
            {
                if (value.HasValue)
                {

                    max_time = (ulong?)new DateTimeOffset((DateTime)value).ToUnixTimeSeconds();
                }
                else
                {
                    max_time = null;
                }
            }
        }

        /// <summary>
        /// Gets or sets the minimum time as a DateTime? object. Converts to and from UNIX time.
        /// </summary>
        [JsonIgnore]
        public DateTime? min_time_DateTime
        {
            get
            {
                if (min_time.HasValue)
                {
                    DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds((long)min_time.Value);
                    return dateTimeOffset.DateTime;
                }
                return null;
            }
            set
            {
                if (value.HasValue)
                {

                    min_time = (ulong?)new DateTimeOffset((DateTime)value).ToUnixTimeSeconds();
                }
                else
                {
                    min_time = null;
                }
            }
        }
    }

}
