Welcome to the CHIA-RPC Nuget package!

This package is a wrapper for RPC-JSON files used to communicate with the Chia client through the HTTP-API, WebSocket API, or CLI. The wrapper allows you to easily create the appropriate RPC object for all wallet endpoint calls, and access the RPC JSON either by calling .ToString() or by saving and loading the JSON file to and from disk.

To install the package, simply run the following command in the Nuget Package Manager console:

Copy code
Install-Package CHIA-RPC
Here is a usage example of the package:

Copy code
SendXCH_RPC rpc = new SendXCH_RPC
{
    address = CommonTestFunctions.TestAdress,
    amount = 1000,
    fee = 0,
    memos = new[] { "this is a testmemo1", "this is a testmemo2" },
    wallet_id = 1
};
GetTransaction_Response response = WalletApi.SendTransaction(rpc).Result;
Thank you for using CHIA-RPC!

## Dependencies
- https://github.com/KryptomineCH/Chia-Metadata
- https://github.com/KryptomineCH/NFT.Storage.Net
