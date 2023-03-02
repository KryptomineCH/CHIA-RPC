﻿using CHIA_RPC.HelperFunctions_NS;

namespace CHIA_RPC.Objects_NS
{
    public class Notification : ObjectTemplate<Notification>
    {
        public ulong amount { get; set; }
        public string id { get; set; }
        public string message { get; set; }
    }
}
