namespace CHIA_RPC.Daemon_NS.Server_NS.ServerObjects_NS
{
    /// <summary>
    /// Enumerates the various Chia services that can be queried for their running status.
    /// </summary>
    public enum ChiaService
    {
        daemon,

        /// <summary>Chia data layer</summary>
        chia_data_layer,

        /// <summary>Chia data layer HTTP</summary>
        chia_data_layer_http,

        /// <summary>Chia wallet</summary>
        chia_wallet,

        /// <summary>Chia full node</summary>
        chia_full_node,

        /// <summary>Chia harvester</summary>
        chia_harvester,

        /// <summary>Chia farmer</summary>
        chia_farmer,

        /// <summary>Chia introducer</summary>
        chia_introducer,

        /// <summary>Chia timelord</summary>
        chia_timelord,

        /// <summary>Chia timelord launcher</summary>
        chia_timelord_launcher,

        /// <summary>Chia full node simulator</summary>
        chia_full_node_simulator,

        /// <summary>Chia seeder</summary>
        chia_seeder,

        /// <summary>Chia crawler</summary>
        chia_crawler,

        /// <summary>Wallet UI</summary>
        wallet_ui,

        /// <summary>
        /// untested
        /// </summary>
        metrics
    }
}
