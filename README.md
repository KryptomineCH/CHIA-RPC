## Welcome to the CHIA-RPC Nuget package!

This package is a wrapper for RPC-JSON files used to communicate with the Chia client through the HTTP-API, WebSocket API, or CLI.  
The wrapper allows you to easily create the appropriate RPC object for all wallet endpoint calls, and deserialize the response JSON and accessing its objets.

> `CHIA-RPC` ONLY contains the rpc wrappers (.net objects for RPC, Response and Chia Objects) In ;rder to cummiunicate with the chia client, you need to either implement your own client solution or use the [`Chia-Client-API`](https://www.nuget.org/packages/Chia-Client-API/) package which implements all rpc endpoints and supports remote management of the chia client. 

## Useful links
- nuget package: https://www.nuget.org/packages/CHIA-RPC  
- github repo to submit issues/requests: https://github.com/KryptomineCH/CHIA-RPC
- official chia rpc documentation: https://docs.chia.net/rpc/
- chia-client-api for communication with the chia client: https://www.nuget.org/packages/Chia-Client-API/

## Usage
### General functions
All classes support the following base functions:
- `SaveToFile(string path)`: saves the rpc as a json-formatted file to the specified path on disk.
- `LoadFromFile(string path)`: loads an rpc file from the specified path from disk.
- `ToString()`: returns a json-formatted string representation of the class.
- `LoadObjectFromString(string json)`: converts a json string (eg. response) into a given object.

### Types
There are 3 types in this library:
- `EndpointName_RPC` these classes represent the request content which is issued against the chia client.
- `EndpointName_Response` these classes represent the chia clients response and are beeing used to deserialize the server response into workable c# objects
- `ObjectName` these classes represent objects in the chia space such as a `CoinRecord`, a `Transaction` and so on

### RPC Creation
Most endpoints are still implemented without a constructor. This means you need to create the RPC and then set its properties:
```C#
// Create a new instance of the SendXCH_RPC class
var rpc = new SendXCH_RPC
{
    wallet_id = 1234,
    address = "chia1q2jzm7eg5t2k8vnq3tkkf5l7zj9mfx9v7p9t5",
    amount = 10000,
    fee = 500,
    memos = new string[] { "Transaction from Example program" }
};
```

Some endpoints already implement Constructors which make things a litte easier:
```C#
GetNextAddress_RPC rpc = new GetNextAddress_RPC(1, false);
```

Some endpoins already have implicit conversions which make working a lot easier. The support is quite sparse still:
```
WalletID_Response walletID = WalletID_Response.LoadResponseFromString(serverResponse);
GetNextAddress_RPC rpc = new GetNextAddress_RPC(walletID);
```

### Serialisation
in order to work with the rpcs, you want to serialize/deserialize them to and from json.
#### Serialisation
All classes have a `.ToString()` method to convert a class to json content:
```c#
WalletID_RPC rpc = new WalletID_RPC(1);
string json = rpc.Tostring();
```
#### Deserialisation
Deserialisation is implemented as static method and can be used to convert the server response:
```c#
GetNextAddress_Response nextAddress = GetNextAddress_Response.LoadResponseFromString(serverResponse);
```

### IO
Often it can be helpful to load and store objects such as an initiated transaction to disk for later reuse:
#### Saving object to disk
All objects and classes implement a SaveToFile method. The method automatically appends a filename .rpc .response or .object in respect of the basetype
```
TransactionID_Response pendingTransaction = new TransactionID_Response();
pendingTransaction.SaveResponseToFile("C:\\temp\\pendingTransactions\\mytransaction-001");
```
#### Loading object from disk
Simmilar to the Deserialisation, loading from disk is implemented as a static method:
```
TransactionID_Response pendingTransaction = TransactionID_Response.LoadResponseFromFile("C:\\temp\\pendingTransactions\\mytransaction-001");
```

### Remarks
> The structure of the chia API can be confusing and many rpcs (eg `WalletID_RPC`) are used for multiple endpoints so it is strongly recommended to use the [`Chia-Client-API`](https://www.nuget.org/packages/Chia-Client-API/) to see how the interaction with the RPC requests is.

> Per default, the chia client will only listen to rpc requests from the local machine.  
If you have remote machines to manage, eg a full node or farmers, you need to enable public port listening.  
For that, edit the chia configuration (default at `~/.chia/mainnet/config/config.yaml`).  
Look for a line starting with self-hostname like so: `self_hostname: &self_hostname "localhost"`   
change it to: `self_hostname: 0.0.0.0` to listen on all interfaces or to the local interface ip to listen on a specific interface.  

For a full documentation besides xml markup, please refer to the official chia documentation:
https://docs.chia.net/rpc

Thank you for using CHIA-RPC!

## Dependencies
- https://github.com/KryptomineCH/Chia-Metadata
- https://github.com/KryptomineCH/NFT.Storage.Net
