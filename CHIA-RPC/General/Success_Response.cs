namespace CHIA_RPC.General
{
    public class Success_Response
    {
        /// <summary>
        /// indicates if the rpc was executed successfully
        /// </summary>
        public bool success { get; set; }
        /// <summary>
        /// in case of rpc failure, there might be an error message attached
        /// </summary>
        public string error { get; set; }
    }
}
