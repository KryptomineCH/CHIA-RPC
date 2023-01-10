Welcome to the CHIA-RPC Nuget package!

This package is a wrapper for RPC-JSON files used to communicate with the Chia client through the HTTP-API, WebSocket API, or CLI. The wrapper allows you to easily create the appropriate RPC object for all wallet endpoint calls, and access the RPC JSON either by calling .ToString() or by saving and loading the JSON file to and from disk.

To install the package, simply run the following command in the Nuget Package Manager console:
It is very recommended to check out the package `Chia-Client-API` as well which uses CHIA-RPC to communicate with the chia client.
```
dotnet add package CHIA-RPC
dotnet add package Chia-Client-API
```

Here is a usage example of how all rpc endpoints are usable:
```
public static void Main()
{
    // Create a new instance of the SendXCH_RPC class
    var rpc = new SendXCH_RPC
    {
        wallet_id = 1234,
        address = "chia1q2jzm7eg5t2k8vnq3tkkf5l7zj9mfx9v7p9t5",
        amount = 10000,
        fee = 500,
        memos = new string[] { "Transaction from Example program" }
    };

    // Print the JSON representation of the RPC
    Console.WriteLine(rpc.ToString());

    // Save the RPC to a file
    rpc.Save("transaction.rpc");

    // Load the RPC from a file
    var loadedRpc = SendXCH_RPC.Load("transaction.rpc");

    // Print the JSON representation of the loaded RPC
    Console.WriteLine(loadedRpc.ToString());
}
```

supported functions for each rpc are:
- The RPC class has several properties (optional and mandatory)
- `Save(string path)`: saves the rpc as a json-formatted file to the specified path.
- `Load(string path)`: loads an rpc file from the specified path.
- `ToString()`: returns a json-formatted string representation of the rpc.

Each RPC has its counter part such as `SendXCH_Response` which is used to deserialize the client response

To use the rpcs, you would create a new instance of it, set its properties, and use its methods to save or load the rpc, and to get a string representation of the object.

It's important to note that this example doesn't actually send a transaction, it's just creating a serialized object which contains information needed to be sent to the network. You need to send it to your own wallet or any other software which can communicate with the network, and finally, the transaction will be broadcasted to the network.

NOTE: `Chia-Client-API` package is available to actually communicate the rpcs to the client

For a full documentation besides xaml markup, please refer to the official chia documentation:
https://docs.chia.net/rpc

Thank you for using CHIA-RPC!

## Dependencies
- https://github.com/KryptomineCH/Chia-Metadata
- https://github.com/KryptomineCH/NFT.Storage.Net
