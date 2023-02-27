namespace CHIA_RPC.FullNode_RPC_NS
{
    public class GetRoutes_Response
    {
        public string[] routes { get; set; }
        /// <summary>
        /// indicates wether the server accepted the request
        /// </summary>
        public bool success { get; set; }
        /// <summary>
        /// if the server refused the request, it will add an error here
        /// </summary>
        public string error { get; set; }
    }
}
