using CHIA_RPC.General_NS;
using CHIA_RPC_Tests.Testhelpers;

namespace CHIA_RPC_Tests.Wallet_NS.RoutesAndConnections_NS
{
    public class Test_GetRoutes
    {
        string[] ExpectedResponseResults = new string[]
        {
            "{\r\n    \"routes\": [\r\n        \"/log_in\",\r\n        \"/get_logged_in_fingerprint\",\r\n        \"/get_public_keys\",\r\n        \"/get_private_key\",\r\n        \"/generate_mnemonic\",\r\n        \"/add_key\",\r\n        \"/delete_key\",\r\n        \"/check_delete_key\",\r\n        \"/delete_all_keys\",\r\n        \"/set_wallet_resync_on_startup\",\r\n        \"/get_sync_status\",\r\n        \"/get_height_info\",\r\n        \"/push_tx\",\r\n        \"/push_transactions\",\r\n        \"/farm_block\",\r\n        \"/get_timestamp_for_height\",\r\n        \"/get_initial_freeze_period\",\r\n        \"/get_network_info\",\r\n        \"/get_wallets\",\r\n        \"/create_new_wallet\",\r\n        \"/get_wallet_balance\",\r\n        \"/get_transaction\",\r\n        \"/get_transactions\",\r\n        \"/get_transaction_count\",\r\n        \"/get_next_address\",\r\n        \"/send_transaction\",\r\n        \"/send_transaction_multi\",\r\n        \"/get_farmed_amount\",\r\n        \"/create_signed_transaction\",\r\n        \"/delete_unconfirmed_transactions\",\r\n        \"/select_coins\",\r\n        \"/get_spendable_coins\",\r\n        \"/get_coin_records_by_names\",\r\n        \"/get_current_derivation_index\",\r\n        \"/extend_derivation_index\",\r\n        \"/get_notifications\",\r\n        \"/delete_notifications\",\r\n        \"/send_notification\",\r\n        \"/sign_message_by_address\",\r\n        \"/sign_message_by_id\",\r\n        \"/verify_signature\",\r\n        \"/get_transaction_memo\",\r\n        \"/cat_set_name\",\r\n        \"/cat_asset_id_to_name\",\r\n        \"/cat_get_name\",\r\n        \"/get_stray_cats\",\r\n        \"/cat_spend\",\r\n        \"/cat_get_asset_id\",\r\n        \"/create_offer_for_ids\",\r\n        \"/get_offer_summary\",\r\n        \"/check_offer_validity\",\r\n        \"/take_offer\",\r\n        \"/get_offer\",\r\n        \"/get_all_offers\",\r\n        \"/get_offers_count\",\r\n        \"/cancel_offer\",\r\n        \"/cancel_offers\",\r\n        \"/get_cat_list\",\r\n        \"/did_set_wallet_name\",\r\n        \"/did_get_wallet_name\",\r\n        \"/did_update_recovery_ids\",\r\n        \"/did_update_metadata\",\r\n        \"/did_get_pubkey\",\r\n        \"/did_get_did\",\r\n        \"/did_recovery_spend\",\r\n        \"/did_get_recovery_list\",\r\n        \"/did_get_metadata\",\r\n        \"/did_create_attest\",\r\n        \"/did_get_information_needed_for_recovery\",\r\n        \"/did_get_current_coin_info\",\r\n        \"/did_create_backup_file\",\r\n        \"/did_transfer_did\",\r\n        \"/did_message_spend\",\r\n        \"/did_get_info\",\r\n        \"/did_find_lost_did\",\r\n        \"/nft_mint_nft\",\r\n        \"/nft_count_nfts\",\r\n        \"/nft_get_nfts\",\r\n        \"/nft_get_by_did\",\r\n        \"/nft_set_nft_did\",\r\n        \"/nft_set_nft_status\",\r\n        \"/nft_get_wallet_did\",\r\n        \"/nft_get_wallets_with_dids\",\r\n        \"/nft_get_info\",\r\n        \"/nft_transfer_nft\",\r\n        \"/nft_add_uri\",\r\n        \"/nft_calculate_royalties\",\r\n        \"/nft_mint_bulk\",\r\n        \"/nft_set_did_bulk\",\r\n        \"/nft_transfer_bulk\",\r\n        \"/pw_join_pool\",\r\n        \"/pw_self_pool\",\r\n        \"/pw_absorb_rewards\",\r\n        \"/pw_status\",\r\n        \"/create_new_dl\",\r\n        \"/dl_track_new\",\r\n        \"/dl_stop_tracking\",\r\n        \"/dl_latest_singleton\",\r\n        \"/dl_singletons_by_root\",\r\n        \"/dl_update_root\",\r\n        \"/dl_update_multiple\",\r\n        \"/dl_history\",\r\n        \"/dl_owned_singletons\",\r\n        \"/dl_get_mirrors\",\r\n        \"/dl_new_mirror\",\r\n        \"/dl_delete_mirror\",\r\n        \"/get_connections\",\r\n        \"/open_connection\",\r\n        \"/close_connection\",\r\n        \"/stop_node\",\r\n        \"/get_routes\",\r\n        \"/healthz\"\r\n    ],\r\n    \"success\": true\r\n}"
        };
        [Fact]
        public void Test_ResponseSerialisation()
        {
            
            Test_ResponseClasses<GetRoutes_Response> helper = new Test_ResponseClasses<GetRoutes_Response>();
            helper.Test_Serialisation(ExpectedResponseResults);
        }
        [Fact]
        public void Test_ResponseDiskIO()
        {
            Test_ResponseClasses<GetRoutes_Response> helper = new Test_ResponseClasses<GetRoutes_Response>();
            helper.Test_DiskIO(ExpectedResponseResults);
        }
    }
}
