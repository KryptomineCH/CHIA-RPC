
namespace CHIA_RPC.General_NS
{
    public static class Settings
    {
        /// <summary>
        /// reports ocurring api errors to Kryptomine.ch, where possible in order to improve the Library.<br/>
        /// this setting is opt-in only. Default is False.
        /// </summary>
        /// <remarks>
        /// Please note that keys or any other login information will not be reported. The reports are AES encrypted and Anonymous <br/>
        /// (Except you add personal information into transaction notes for example)
        /// </remarks>
        public static bool ReportErrors { get; set; } = false;
    }
}
