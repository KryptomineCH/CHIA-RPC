using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.General
{
    /// <summary>
    /// This is the most basic response which the chia node returns. It just contains a boolean success and an optional error message.
    /// </summary>
    public class Success_Response : ResponseTemplate<Success_Response>
    {
        /// inherits all Properties and functions from the Response Template as the template is originally created from this class
    }
}
