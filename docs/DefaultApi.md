# MarloweAPIClient.Api.DefaultApi

All URIs are relative to *https://marlowe-runtime-preprod-web.scdev.aws.iohkdev.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApplyInputsToContract**](DefaultApi.md#applyinputstocontract) | **POST** /contracts/{contractId}/transactions | Apply inputs to contract |
| [**CreateContract**](DefaultApi.md#createcontract) | **POST** /contracts | Create a new contract |
| [**CreateContractSources**](DefaultApi.md#createcontractsources) | **POST** /contracts/sources | Upload contract sources |
| [**GetContractById**](DefaultApi.md#getcontractbyid) | **GET** /contracts/{contractId} | Get contract by ID |
| [**GetContractSourceAdjacency**](DefaultApi.md#getcontractsourceadjacency) | **GET** /contracts/sources/{contractSourceId}/adjacency | Get adjacent contract source IDs by ID |
| [**GetContractSourceById**](DefaultApi.md#getcontractsourcebyid) | **GET** /contracts/sources/{contractSourceId} | Get contract source by ID |
| [**GetContractSourceClosure**](DefaultApi.md#getcontractsourceclosure) | **GET** /contracts/sources/{contractSourceId}/closure | Get contract source closure by ID |
| [**GetContractTransactionById**](DefaultApi.md#getcontracttransactionbyid) | **GET** /contracts/{contractId}/transactions/{transactionId} | Get contract transaction by ID |
| [**GetContracts**](DefaultApi.md#getcontracts) | **GET** /contracts | Get contracts |
| [**GetNextStepsForContract**](DefaultApi.md#getnextstepsforcontract) | **GET** /contracts/{contractId}/next | Get next contract steps |
| [**GetPayoutById**](DefaultApi.md#getpayoutbyid) | **GET** /payouts/{payoutId} | Get payout by ID |
| [**GetPayouts**](DefaultApi.md#getpayouts) | **GET** /payouts | Get role payouts |
| [**GetTransactionsForContract**](DefaultApi.md#gettransactionsforcontract) | **GET** /contracts/{contractId}/transactions | Get transactions for contract |
| [**GetWithdrawalById**](DefaultApi.md#getwithdrawalbyid) | **GET** /withdrawals/{withdrawalId} | Get withdrawal by ID |
| [**GetWithdrawals**](DefaultApi.md#getwithdrawals) | **GET** /withdrawals | Get withdrawals |
| [**Healthcheck**](DefaultApi.md#healthcheck) | **GET** /healthcheck | Test server status |
| [**SubmitContract**](DefaultApi.md#submitcontract) | **PUT** /contracts/{contractId} | Submit contract to chain |
| [**SubmitContractTransaction**](DefaultApi.md#submitcontracttransaction) | **PUT** /contracts/{contractId}/transactions/{transactionId} | Submit contract input application |
| [**SubmitWithdrawal**](DefaultApi.md#submitwithdrawal) | **PUT** /withdrawals/{withdrawalId} | Submit payout withdrawal |
| [**WithdrawPayouts**](DefaultApi.md#withdrawpayouts) | **POST** /withdrawals | Withdraw payouts |

<a id="applyinputstocontract"></a>
# **ApplyInputsToContract**
> ApplyInputsResponse ApplyInputsToContract (string contractId, string xChangeAddress, string? xAddress = null, string? xCollateralUTxO = null, PostTransactionsRequest? postTransactionsRequest = null)

Apply inputs to contract

Build an unsigned (Cardano) transaction body which applies inputs to an open Marlowe contract. This unsigned transaction must be signed by a wallet (such as a CIP-30 or CIP-45 wallet) before being submitted. To submit the signed transaction, use the PUT /contracts/{contractId}/transactions/{transactionId} endpoint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarloweAPIClient.Api;
using MarloweAPIClient.Client;
using MarloweAPIClient.Model;

namespace Example
{
    public class ApplyInputsToContractExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://marlowe-runtime-preprod-web.scdev.aws.iohkdev.io";
            var apiInstance = new DefaultApi(config);
            var contractId = 98d601c9307dd43307cf68a03aad0086d4e07a789b66919ccf9f7f7676577eb7%231;  // string | 
            var xChangeAddress = addr1w94f8ywk4fg672xasahtk4t9k6w3aql943uxz5rt62d4dvq8evxaf;  // string | 
            var xAddress = "xAddress_example";  // string? |  (optional) 
            var xCollateralUTxO = "xCollateralUTxO_example";  // string? |  (optional) 
            var postTransactionsRequest = new PostTransactionsRequest?(); // PostTransactionsRequest? |  (optional) 

            try
            {
                // Apply inputs to contract
                ApplyInputsResponse result = apiInstance.ApplyInputsToContract(contractId, xChangeAddress, xAddress, xCollateralUTxO, postTransactionsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ApplyInputsToContract: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApplyInputsToContractWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Apply inputs to contract
    ApiResponse<ApplyInputsResponse> response = apiInstance.ApplyInputsToContractWithHttpInfo(contractId, xChangeAddress, xAddress, xCollateralUTxO, postTransactionsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ApplyInputsToContractWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contractId** | **string** |  |  |
| **xChangeAddress** | **string** |  |  |
| **xAddress** | **string?** |  | [optional]  |
| **xCollateralUTxO** | **string?** |  | [optional]  |
| **postTransactionsRequest** | [**PostTransactionsRequest?**](PostTransactionsRequest?.md) |  | [optional]  |

### Return type

[**ApplyInputsResponse**](ApplyInputsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/vendor.iog.marlowe-runtime.apply-inputs-tx-json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** |  |  * X-Network-Id -  <br>  * X-Node-Tip -  <br>  * X-Runtime-Chain-Tip -  <br>  * X-Runtime-Tip -  <br>  * X-Runtime-Version -  <br>  |
| **400** | Invalid &#x60;X-Collateral-UTxO&#x60; or &#x60;X-Address&#x60; or &#x60;X-Change-Address&#x60; or &#x60;body&#x60; |  -  |
| **404** | &#x60;contractId&#x60; not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createcontract"></a>
# **CreateContract**
> CreateContractResponse CreateContract (string xChangeAddress, string? xStakeAddress = null, string? xAddress = null, string? xCollateralUTxO = null, PostContractsRequest? postContractsRequest = null)

Create a new contract

Build an unsigned (Cardano) transaction body which opens a new Marlowe contract. This unsigned transaction must be signed by a wallet (such as a CIP-30 or CIP-45 wallet) before being submitted. To submit the signed transaction, use the PUT /contracts/{contractId} endpoint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarloweAPIClient.Api;
using MarloweAPIClient.Client;
using MarloweAPIClient.Model;

namespace Example
{
    public class CreateContractExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://marlowe-runtime-preprod-web.scdev.aws.iohkdev.io";
            var apiInstance = new DefaultApi(config);
            var xChangeAddress = addr1w94f8ywk4fg672xasahtk4t9k6w3aql943uxz5rt62d4dvq8evxaf;  // string | 
            var xStakeAddress = stake1ux7lyy9nhecm033qsmel9awnr22up6jadlzkrxufr78w82gsfsn0d;  // string? | Where to send staking rewards for the Marlowe script outputs of this contract. (optional) 
            var xAddress = "xAddress_example";  // string? |  (optional) 
            var xCollateralUTxO = "xCollateralUTxO_example";  // string? |  (optional) 
            var postContractsRequest = new PostContractsRequest?(); // PostContractsRequest? |  (optional) 

            try
            {
                // Create a new contract
                CreateContractResponse result = apiInstance.CreateContract(xChangeAddress, xStakeAddress, xAddress, xCollateralUTxO, postContractsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateContract: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateContractWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new contract
    ApiResponse<CreateContractResponse> response = apiInstance.CreateContractWithHttpInfo(xChangeAddress, xStakeAddress, xAddress, xCollateralUTxO, postContractsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CreateContractWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xChangeAddress** | **string** |  |  |
| **xStakeAddress** | **string?** | Where to send staking rewards for the Marlowe script outputs of this contract. | [optional]  |
| **xAddress** | **string?** |  | [optional]  |
| **xCollateralUTxO** | **string?** |  | [optional]  |
| **postContractsRequest** | [**PostContractsRequest?**](PostContractsRequest?.md) |  | [optional]  |

### Return type

[**CreateContractResponse**](CreateContractResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/vendor.iog.marlowe-runtime.contract-tx-json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** |  |  * X-Network-Id -  <br>  * X-Node-Tip -  <br>  * X-Runtime-Chain-Tip -  <br>  * X-Runtime-Tip -  <br>  * X-Runtime-Version -  <br>  |
| **400** | Invalid &#x60;X-Collateral-UTxO&#x60; or &#x60;X-Address&#x60; or &#x60;X-Change-Address&#x60; or &#x60;body&#x60; or &#x60;X-Stake-Address&#x60; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createcontractsources"></a>
# **CreateContractSources**
> PostContractSourceResponse CreateContractSources (string main, List<LabelledObject>? labelledObject = null)

Upload contract sources

Upload a bundle of marlowe objects as contract sources. This API supports request body streaming, with newline framing between request bundles.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarloweAPIClient.Api;
using MarloweAPIClient.Client;
using MarloweAPIClient.Model;

namespace Example
{
    public class CreateContractSourcesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://marlowe-runtime-preprod-web.scdev.aws.iohkdev.io";
            var apiInstance = new DefaultApi(config);
            var main = "main_example";  // string | The label of the top-level contract object in the bundle(s).
            var labelledObject = new List<LabelledObject>?(); // List<LabelledObject>? |  (optional) 

            try
            {
                // Upload contract sources
                PostContractSourceResponse result = apiInstance.CreateContractSources(main, labelledObject);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateContractSources: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateContractSourcesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Upload contract sources
    ApiResponse<PostContractSourceResponse> response = apiInstance.CreateContractSourcesWithHttpInfo(main, labelledObject);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CreateContractSourcesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **main** | **string** | The label of the top-level contract object in the bundle(s). |  |
| **labelledObject** | [**List&lt;LabelledObject&gt;?**](LabelledObject.md) |  | [optional]  |

### Return type

[**PostContractSourceResponse**](PostContractSourceResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  * X-Network-Id -  <br>  * X-Node-Tip -  <br>  * X-Runtime-Chain-Tip -  <br>  * X-Runtime-Tip -  <br>  * X-Runtime-Version -  <br>  |
| **400** | Invalid &#x60;body&#x60; or &#x60;main&#x60; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcontractbyid"></a>
# **GetContractById**
> GetContractResponse GetContractById (string contractId)

Get contract by ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarloweAPIClient.Api;
using MarloweAPIClient.Client;
using MarloweAPIClient.Model;

namespace Example
{
    public class GetContractByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://marlowe-runtime-preprod-web.scdev.aws.iohkdev.io";
            var apiInstance = new DefaultApi(config);
            var contractId = 98d601c9307dd43307cf68a03aad0086d4e07a789b66919ccf9f7f7676577eb7%231;  // string | 

            try
            {
                // Get contract by ID
                GetContractResponse result = apiInstance.GetContractById(contractId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetContractById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetContractByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get contract by ID
    ApiResponse<GetContractResponse> response = apiInstance.GetContractByIdWithHttpInfo(contractId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetContractByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contractId** | **string** |  |  |

### Return type

[**GetContractResponse**](GetContractResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=utf-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  * X-Network-Id -  <br>  * X-Node-Tip -  <br>  * X-Runtime-Chain-Tip -  <br>  * X-Runtime-Tip -  <br>  * X-Runtime-Version -  <br>  |
| **404** | &#x60;contractId&#x60; not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcontractsourceadjacency"></a>
# **GetContractSourceAdjacency**
> ContractSourceIds GetContractSourceAdjacency (string contractSourceId)

Get adjacent contract source IDs by ID

Get the contract source IDs which are adjacent to a contract source (they appear directly in the contract source).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarloweAPIClient.Api;
using MarloweAPIClient.Client;
using MarloweAPIClient.Model;

namespace Example
{
    public class GetContractSourceAdjacencyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://marlowe-runtime-preprod-web.scdev.aws.iohkdev.io";
            var apiInstance = new DefaultApi(config);
            var contractSourceId = "contractSourceId_example";  // string | 

            try
            {
                // Get adjacent contract source IDs by ID
                ContractSourceIds result = apiInstance.GetContractSourceAdjacency(contractSourceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetContractSourceAdjacency: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetContractSourceAdjacencyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get adjacent contract source IDs by ID
    ApiResponse<ContractSourceIds> response = apiInstance.GetContractSourceAdjacencyWithHttpInfo(contractSourceId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetContractSourceAdjacencyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contractSourceId** | **string** |  |  |

### Return type

[**ContractSourceIds**](ContractSourceIds.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=utf-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  * X-Network-Id -  <br>  * X-Node-Tip -  <br>  * X-Runtime-Chain-Tip -  <br>  * X-Runtime-Tip -  <br>  * X-Runtime-Version -  <br>  |
| **404** | &#x60;contractSourceId&#x60; not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcontractsourcebyid"></a>
# **GetContractSourceById**
> Contract GetContractSourceById (string contractSourceId, bool? expand = null)

Get contract source by ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarloweAPIClient.Api;
using MarloweAPIClient.Client;
using MarloweAPIClient.Model;

namespace Example
{
    public class GetContractSourceByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://marlowe-runtime-preprod-web.scdev.aws.iohkdev.io";
            var apiInstance = new DefaultApi(config);
            var contractSourceId = "contractSourceId_example";  // string | 
            var expand = false;  // bool? |  (optional)  (default to false)

            try
            {
                // Get contract source by ID
                Contract result = apiInstance.GetContractSourceById(contractSourceId, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetContractSourceById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetContractSourceByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get contract source by ID
    ApiResponse<Contract> response = apiInstance.GetContractSourceByIdWithHttpInfo(contractSourceId, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetContractSourceByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contractSourceId** | **string** |  |  |
| **expand** | **bool?** |  | [optional] [default to false] |

### Return type

[**Contract**](Contract.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=utf-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  * X-Network-Id -  <br>  * X-Node-Tip -  <br>  * X-Runtime-Chain-Tip -  <br>  * X-Runtime-Tip -  <br>  * X-Runtime-Version -  <br>  |
| **400** | Invalid &#x60;expand&#x60; |  -  |
| **404** | &#x60;contractSourceId&#x60; not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcontractsourceclosure"></a>
# **GetContractSourceClosure**
> ContractSourceIds GetContractSourceClosure (string contractSourceId)

Get contract source closure by ID

Get the contract source IDs which appear in the full hierarchy of a contract source (including the ID of the contract source its self).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarloweAPIClient.Api;
using MarloweAPIClient.Client;
using MarloweAPIClient.Model;

namespace Example
{
    public class GetContractSourceClosureExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://marlowe-runtime-preprod-web.scdev.aws.iohkdev.io";
            var apiInstance = new DefaultApi(config);
            var contractSourceId = "contractSourceId_example";  // string | 

            try
            {
                // Get contract source closure by ID
                ContractSourceIds result = apiInstance.GetContractSourceClosure(contractSourceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetContractSourceClosure: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetContractSourceClosureWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get contract source closure by ID
    ApiResponse<ContractSourceIds> response = apiInstance.GetContractSourceClosureWithHttpInfo(contractSourceId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetContractSourceClosureWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contractSourceId** | **string** |  |  |

### Return type

[**ContractSourceIds**](ContractSourceIds.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=utf-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  * X-Network-Id -  <br>  * X-Node-Tip -  <br>  * X-Runtime-Chain-Tip -  <br>  * X-Runtime-Tip -  <br>  * X-Runtime-Version -  <br>  |
| **404** | &#x60;contractSourceId&#x60; not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcontracttransactionbyid"></a>
# **GetContractTransactionById**
> GetTransactionResponse GetContractTransactionById (string contractId, string transactionId)

Get contract transaction by ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarloweAPIClient.Api;
using MarloweAPIClient.Client;
using MarloweAPIClient.Model;

namespace Example
{
    public class GetContractTransactionByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://marlowe-runtime-preprod-web.scdev.aws.iohkdev.io";
            var apiInstance = new DefaultApi(config);
            var contractId = 98d601c9307dd43307cf68a03aad0086d4e07a789b66919ccf9f7f7676577eb7%231;  // string | 
            var transactionId = "transactionId_example";  // string | 

            try
            {
                // Get contract transaction by ID
                GetTransactionResponse result = apiInstance.GetContractTransactionById(contractId, transactionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetContractTransactionById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetContractTransactionByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get contract transaction by ID
    ApiResponse<GetTransactionResponse> response = apiInstance.GetContractTransactionByIdWithHttpInfo(contractId, transactionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetContractTransactionByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contractId** | **string** |  |  |
| **transactionId** | **string** |  |  |

### Return type

[**GetTransactionResponse**](GetTransactionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=utf-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  * X-Network-Id -  <br>  * X-Node-Tip -  <br>  * X-Runtime-Chain-Tip -  <br>  * X-Runtime-Tip -  <br>  * X-Runtime-Version -  <br>  |
| **404** | &#x60;contractId&#x60; or &#x60;transactionId&#x60; not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcontracts"></a>
# **GetContracts**
> GetContractsResponse GetContracts (List<string>? roleCurrency = null, List<string>? tag = null, List<string>? partyAddress = null, List<string>? partyRole = null, string? range = null)

Get contracts

Get contracts published on chain. Results are returned in pages, with paging being specified by request headers.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarloweAPIClient.Api;
using MarloweAPIClient.Client;
using MarloweAPIClient.Model;

namespace Example
{
    public class GetContractsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://marlowe-runtime-preprod-web.scdev.aws.iohkdev.io";
            var apiInstance = new DefaultApi(config);
            var roleCurrency = new List<string>?(); // List<string>? |  (optional) 
            var tag = new List<string>?(); // List<string>? |  (optional) 
            var partyAddress = new List<string>?(); // List<string>? |  (optional) 
            var partyRole = new List<string>?(); // List<string>? |  (optional) 
            var range = "range_example";  // string? |  (optional) 

            try
            {
                // Get contracts
                GetContractsResponse result = apiInstance.GetContracts(roleCurrency, tag, partyAddress, partyRole, range);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetContracts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetContractsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get contracts
    ApiResponse<GetContractsResponse> response = apiInstance.GetContractsWithHttpInfo(roleCurrency, tag, partyAddress, partyRole, range);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetContractsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **roleCurrency** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **tag** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **partyAddress** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **partyRole** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **range** | **string?** |  | [optional]  |

### Return type

[**GetContractsResponse**](GetContractsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=utf-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **206** |  |  * Accept-Ranges -  <br>  * Content-Range -  <br>  * Next-Range -  <br>  * Total-Count -  <br>  * X-Network-Id -  <br>  * X-Node-Tip -  <br>  * X-Runtime-Chain-Tip -  <br>  * X-Runtime-Tip -  <br>  * X-Runtime-Version -  <br>  |
| **400** | Invalid &#x60;Range&#x60; or &#x60;partyRole&#x60; or &#x60;partyAddress&#x60; or &#x60;tag&#x60; or &#x60;roleCurrency&#x60; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getnextstepsforcontract"></a>
# **GetNextStepsForContract**
> Next GetNextStepsForContract (string contractId, string validityStart, string validityEnd, List<string>? party = null)

Get next contract steps

Get inputs which could be performed on a contract withing a time range by the requested parties.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarloweAPIClient.Api;
using MarloweAPIClient.Client;
using MarloweAPIClient.Model;

namespace Example
{
    public class GetNextStepsForContractExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://marlowe-runtime-preprod-web.scdev.aws.iohkdev.io";
            var apiInstance = new DefaultApi(config);
            var contractId = 98d601c9307dd43307cf68a03aad0086d4e07a789b66919ccf9f7f7676577eb7%231;  // string | 
            var validityStart = "validityStart_example";  // string | The beginning of the validity range.
            var validityEnd = "validityEnd_example";  // string | The end of the validity range.
            var party = new List<string>?(); // List<string>? |  (optional) 

            try
            {
                // Get next contract steps
                Next result = apiInstance.GetNextStepsForContract(contractId, validityStart, validityEnd, party);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetNextStepsForContract: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetNextStepsForContractWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get next contract steps
    ApiResponse<Next> response = apiInstance.GetNextStepsForContractWithHttpInfo(contractId, validityStart, validityEnd, party);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetNextStepsForContractWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contractId** | **string** |  |  |
| **validityStart** | **string** | The beginning of the validity range. |  |
| **validityEnd** | **string** | The end of the validity range. |  |
| **party** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |

### Return type

[**Next**](Next.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=utf-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  * X-Network-Id -  <br>  * X-Node-Tip -  <br>  * X-Runtime-Chain-Tip -  <br>  * X-Runtime-Tip -  <br>  * X-Runtime-Version -  <br>  |
| **400** | Invalid &#x60;party&#x60; or &#x60;validityEnd&#x60; or &#x60;validityStart&#x60; |  -  |
| **404** | &#x60;contractId&#x60; not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getpayoutbyid"></a>
# **GetPayoutById**
> GetPayoutResponse GetPayoutById (string payoutId)

Get payout by ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarloweAPIClient.Api;
using MarloweAPIClient.Client;
using MarloweAPIClient.Model;

namespace Example
{
    public class GetPayoutByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://marlowe-runtime-preprod-web.scdev.aws.iohkdev.io";
            var apiInstance = new DefaultApi(config);
            var payoutId = 98d601c9307dd43307cf68a03aad0086d4e07a789b66919ccf9f7f7676577eb7%231;  // string | 

            try
            {
                // Get payout by ID
                GetPayoutResponse result = apiInstance.GetPayoutById(payoutId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetPayoutById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPayoutByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get payout by ID
    ApiResponse<GetPayoutResponse> response = apiInstance.GetPayoutByIdWithHttpInfo(payoutId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetPayoutByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **payoutId** | **string** |  |  |

### Return type

[**GetPayoutResponse**](GetPayoutResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=utf-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  * X-Network-Id -  <br>  * X-Node-Tip -  <br>  * X-Runtime-Chain-Tip -  <br>  * X-Runtime-Tip -  <br>  * X-Runtime-Version -  <br>  |
| **404** | &#x60;payoutId&#x60; not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getpayouts"></a>
# **GetPayouts**
> GetPayoutsResponse GetPayouts (List<string>? contractId = null, List<string>? roleToken = null, string? status = null, string? range = null)

Get role payouts

Get payouts to parties from role-based contracts. Results are returned in pages, with paging being specified by request headers.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarloweAPIClient.Api;
using MarloweAPIClient.Client;
using MarloweAPIClient.Model;

namespace Example
{
    public class GetPayoutsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://marlowe-runtime-preprod-web.scdev.aws.iohkdev.io";
            var apiInstance = new DefaultApi(config);
            var contractId = new List<string>?(); // List<string>? |  (optional) 
            var roleToken = new List<string>?(); // List<string>? |  (optional) 
            var status = "available";  // string? | Whether to include available or withdrawn payouts in the results. (optional) 
            var range = "range_example";  // string? |  (optional) 

            try
            {
                // Get role payouts
                GetPayoutsResponse result = apiInstance.GetPayouts(contractId, roleToken, status, range);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetPayouts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPayoutsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get role payouts
    ApiResponse<GetPayoutsResponse> response = apiInstance.GetPayoutsWithHttpInfo(contractId, roleToken, status, range);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetPayoutsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contractId** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **roleToken** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **status** | **string?** | Whether to include available or withdrawn payouts in the results. | [optional]  |
| **range** | **string?** |  | [optional]  |

### Return type

[**GetPayoutsResponse**](GetPayoutsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=utf-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **206** |  |  * Accept-Ranges -  <br>  * Content-Range -  <br>  * Next-Range -  <br>  * Total-Count -  <br>  * X-Network-Id -  <br>  * X-Node-Tip -  <br>  * X-Runtime-Chain-Tip -  <br>  * X-Runtime-Tip -  <br>  * X-Runtime-Version -  <br>  |
| **400** | Invalid &#x60;Range&#x60; or &#x60;status&#x60; or &#x60;roleToken&#x60; or &#x60;contractId&#x60; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettransactionsforcontract"></a>
# **GetTransactionsForContract**
> GetTransactionsResponse GetTransactionsForContract (string contractId, string? range = null)

Get transactions for contract

Get published transactions for a contract. Results are returned in pages, with paging being specified by request headers.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarloweAPIClient.Api;
using MarloweAPIClient.Client;
using MarloweAPIClient.Model;

namespace Example
{
    public class GetTransactionsForContractExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://marlowe-runtime-preprod-web.scdev.aws.iohkdev.io";
            var apiInstance = new DefaultApi(config);
            var contractId = 98d601c9307dd43307cf68a03aad0086d4e07a789b66919ccf9f7f7676577eb7%231;  // string | 
            var range = "range_example";  // string? |  (optional) 

            try
            {
                // Get transactions for contract
                GetTransactionsResponse result = apiInstance.GetTransactionsForContract(contractId, range);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetTransactionsForContract: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTransactionsForContractWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get transactions for contract
    ApiResponse<GetTransactionsResponse> response = apiInstance.GetTransactionsForContractWithHttpInfo(contractId, range);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetTransactionsForContractWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contractId** | **string** |  |  |
| **range** | **string?** |  | [optional]  |

### Return type

[**GetTransactionsResponse**](GetTransactionsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=utf-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **206** |  |  * Accept-Ranges -  <br>  * Content-Range -  <br>  * Next-Range -  <br>  * Total-Count -  <br>  * X-Network-Id -  <br>  * X-Node-Tip -  <br>  * X-Runtime-Chain-Tip -  <br>  * X-Runtime-Tip -  <br>  * X-Runtime-Version -  <br>  |
| **400** | Invalid &#x60;Range&#x60; |  -  |
| **404** | &#x60;contractId&#x60; not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getwithdrawalbyid"></a>
# **GetWithdrawalById**
> Withdrawal GetWithdrawalById (string withdrawalId)

Get withdrawal by ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarloweAPIClient.Api;
using MarloweAPIClient.Client;
using MarloweAPIClient.Model;

namespace Example
{
    public class GetWithdrawalByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://marlowe-runtime-preprod-web.scdev.aws.iohkdev.io";
            var apiInstance = new DefaultApi(config);
            var withdrawalId = "withdrawalId_example";  // string | 

            try
            {
                // Get withdrawal by ID
                Withdrawal result = apiInstance.GetWithdrawalById(withdrawalId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetWithdrawalById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWithdrawalByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get withdrawal by ID
    ApiResponse<Withdrawal> response = apiInstance.GetWithdrawalByIdWithHttpInfo(withdrawalId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetWithdrawalByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **withdrawalId** | **string** |  |  |

### Return type

[**Withdrawal**](Withdrawal.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=utf-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  * X-Network-Id -  <br>  * X-Node-Tip -  <br>  * X-Runtime-Chain-Tip -  <br>  * X-Runtime-Tip -  <br>  * X-Runtime-Version -  <br>  |
| **404** | &#x60;withdrawalId&#x60; not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getwithdrawals"></a>
# **GetWithdrawals**
> GetWithdrawalsResponse GetWithdrawals (List<string>? roleCurrency = null, string? range = null)

Get withdrawals

Get published withdrawal transactions. Results are returned in pages, with paging being specified by request headers.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarloweAPIClient.Api;
using MarloweAPIClient.Client;
using MarloweAPIClient.Model;

namespace Example
{
    public class GetWithdrawalsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://marlowe-runtime-preprod-web.scdev.aws.iohkdev.io";
            var apiInstance = new DefaultApi(config);
            var roleCurrency = new List<string>?(); // List<string>? |  (optional) 
            var range = "range_example";  // string? |  (optional) 

            try
            {
                // Get withdrawals
                GetWithdrawalsResponse result = apiInstance.GetWithdrawals(roleCurrency, range);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetWithdrawals: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWithdrawalsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get withdrawals
    ApiResponse<GetWithdrawalsResponse> response = apiInstance.GetWithdrawalsWithHttpInfo(roleCurrency, range);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetWithdrawalsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **roleCurrency** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **range** | **string?** |  | [optional]  |

### Return type

[**GetWithdrawalsResponse**](GetWithdrawalsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=utf-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **206** |  |  * Accept-Ranges -  <br>  * Content-Range -  <br>  * Next-Range -  <br>  * Total-Count -  <br>  * X-Network-Id -  <br>  * X-Node-Tip -  <br>  * X-Runtime-Chain-Tip -  <br>  * X-Runtime-Tip -  <br>  * X-Runtime-Version -  <br>  |
| **400** | Invalid &#x60;Range&#x60; or &#x60;roleCurrency&#x60; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="healthcheck"></a>
# **Healthcheck**
> void Healthcheck ()

Test server status

Check if the server is running and ready to respond to requests.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarloweAPIClient.Api;
using MarloweAPIClient.Client;
using MarloweAPIClient.Model;

namespace Example
{
    public class HealthcheckExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://marlowe-runtime-preprod-web.scdev.aws.iohkdev.io";
            var apiInstance = new DefaultApi(config);

            try
            {
                // Test server status
                apiInstance.Healthcheck();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.Healthcheck: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HealthcheckWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Test server status
    apiInstance.HealthcheckWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.HealthcheckWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=utf-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  * X-Network-Id -  <br>  * X-Node-Tip -  <br>  * X-Runtime-Chain-Tip -  <br>  * X-Runtime-Tip -  <br>  * X-Runtime-Version -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="submitcontract"></a>
# **SubmitContract**
> void SubmitContract (string contractId, TextEnvelope? textEnvelope = null)

Submit contract to chain

Submit a signed (Cardano) transaction that opens a new Marlowe contract. The transaction must have originally been created by the POST /contracts endpoint. This endpoint will respond when the transaction is submitted successfully to the local node, which means it will not wait for the transaction to be published in a block. Use the GET /contracts/{contractId} endpoint to poll the on-chain status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarloweAPIClient.Api;
using MarloweAPIClient.Client;
using MarloweAPIClient.Model;

namespace Example
{
    public class SubmitContractExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://marlowe-runtime-preprod-web.scdev.aws.iohkdev.io";
            var apiInstance = new DefaultApi(config);
            var contractId = 98d601c9307dd43307cf68a03aad0086d4e07a789b66919ccf9f7f7676577eb7%231;  // string | 
            var textEnvelope = new TextEnvelope?(); // TextEnvelope? |  (optional) 

            try
            {
                // Submit contract to chain
                apiInstance.SubmitContract(contractId, textEnvelope);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.SubmitContract: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubmitContractWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Submit contract to chain
    apiInstance.SubmitContractWithHttpInfo(contractId, textEnvelope);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.SubmitContractWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contractId** | **string** |  |  |
| **textEnvelope** | [**TextEnvelope?**](TextEnvelope?.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** |  |  * X-Network-Id -  <br>  * X-Node-Tip -  <br>  * X-Runtime-Chain-Tip -  <br>  * X-Runtime-Tip -  <br>  * X-Runtime-Version -  <br>  |
| **400** | Invalid &#x60;body&#x60; |  -  |
| **404** | &#x60;contractId&#x60; not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="submitcontracttransaction"></a>
# **SubmitContractTransaction**
> void SubmitContractTransaction (string contractId, string transactionId, TextEnvelope? textEnvelope = null)

Submit contract input application

Submit a signed (Cardano) transaction that applies inputs to an open Marlowe contract. The transaction must have originally been created by the POST /contracts/{contractId}/transactions endpoint. This endpoint will respond when the transaction is submitted successfully to the local node, which means it will not wait for the transaction to be published in a block. Use the GET /contracts/{contractId}/transactions/{transactionId} endpoint to poll the on-chain status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarloweAPIClient.Api;
using MarloweAPIClient.Client;
using MarloweAPIClient.Model;

namespace Example
{
    public class SubmitContractTransactionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://marlowe-runtime-preprod-web.scdev.aws.iohkdev.io";
            var apiInstance = new DefaultApi(config);
            var contractId = 98d601c9307dd43307cf68a03aad0086d4e07a789b66919ccf9f7f7676577eb7%231;  // string | 
            var transactionId = "transactionId_example";  // string | 
            var textEnvelope = new TextEnvelope?(); // TextEnvelope? |  (optional) 

            try
            {
                // Submit contract input application
                apiInstance.SubmitContractTransaction(contractId, transactionId, textEnvelope);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.SubmitContractTransaction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubmitContractTransactionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Submit contract input application
    apiInstance.SubmitContractTransactionWithHttpInfo(contractId, transactionId, textEnvelope);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.SubmitContractTransactionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contractId** | **string** |  |  |
| **transactionId** | **string** |  |  |
| **textEnvelope** | [**TextEnvelope?**](TextEnvelope?.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** |  |  * X-Network-Id -  <br>  * X-Node-Tip -  <br>  * X-Runtime-Chain-Tip -  <br>  * X-Runtime-Tip -  <br>  * X-Runtime-Version -  <br>  |
| **400** | Invalid &#x60;body&#x60; |  -  |
| **404** | &#x60;contractId&#x60; or &#x60;transactionId&#x60; not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="submitwithdrawal"></a>
# **SubmitWithdrawal**
> void SubmitWithdrawal (string withdrawalId, TextEnvelope? textEnvelope = null)

Submit payout withdrawal

Submit a signed (Cardano) transaction that withdraws available payouts from a role payout validator. The transaction must have originally been created by the POST /withdrawals endpoint. This endpoint will respond when the transaction is submitted successfully to the local node, which means it will not wait for the transaction to be published in a block. Use the GET /withdrawals/{withdrawalId} endpoint to poll the on-chain status.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarloweAPIClient.Api;
using MarloweAPIClient.Client;
using MarloweAPIClient.Model;

namespace Example
{
    public class SubmitWithdrawalExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://marlowe-runtime-preprod-web.scdev.aws.iohkdev.io";
            var apiInstance = new DefaultApi(config);
            var withdrawalId = "withdrawalId_example";  // string | 
            var textEnvelope = new TextEnvelope?(); // TextEnvelope? |  (optional) 

            try
            {
                // Submit payout withdrawal
                apiInstance.SubmitWithdrawal(withdrawalId, textEnvelope);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.SubmitWithdrawal: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubmitWithdrawalWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Submit payout withdrawal
    apiInstance.SubmitWithdrawalWithHttpInfo(withdrawalId, textEnvelope);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.SubmitWithdrawalWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **withdrawalId** | **string** |  |  |
| **textEnvelope** | [**TextEnvelope?**](TextEnvelope?.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/json;charset=utf-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** |  |  * X-Network-Id -  <br>  * X-Node-Tip -  <br>  * X-Runtime-Chain-Tip -  <br>  * X-Runtime-Tip -  <br>  * X-Runtime-Version -  <br>  |
| **400** | Invalid &#x60;body&#x60; |  -  |
| **404** | &#x60;withdrawalId&#x60; not found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="withdrawpayouts"></a>
# **WithdrawPayouts**
> WithdrawPayoutsResponse WithdrawPayouts (string xChangeAddress, string? xAddress = null, string? xCollateralUTxO = null, PostWithdrawalsRequest? postWithdrawalsRequest = null)

Withdraw payouts

Build an unsigned (Cardano) transaction body which withdraws available payouts from a role payout validator. This unsigned transaction must be signed by a wallet (such as a CIP-30 or CIP-45 wallet) before being submitted. To submit the signed transaction, use the PUT /withdrawals/{withdrawalId} endpoint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarloweAPIClient.Api;
using MarloweAPIClient.Client;
using MarloweAPIClient.Model;

namespace Example
{
    public class WithdrawPayoutsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://marlowe-runtime-preprod-web.scdev.aws.iohkdev.io";
            var apiInstance = new DefaultApi(config);
            var xChangeAddress = addr1w94f8ywk4fg672xasahtk4t9k6w3aql943uxz5rt62d4dvq8evxaf;  // string | 
            var xAddress = "xAddress_example";  // string? |  (optional) 
            var xCollateralUTxO = "xCollateralUTxO_example";  // string? |  (optional) 
            var postWithdrawalsRequest = new PostWithdrawalsRequest?(); // PostWithdrawalsRequest? |  (optional) 

            try
            {
                // Withdraw payouts
                WithdrawPayoutsResponse result = apiInstance.WithdrawPayouts(xChangeAddress, xAddress, xCollateralUTxO, postWithdrawalsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.WithdrawPayouts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WithdrawPayoutsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Withdraw payouts
    ApiResponse<WithdrawPayoutsResponse> response = apiInstance.WithdrawPayoutsWithHttpInfo(xChangeAddress, xAddress, xCollateralUTxO, postWithdrawalsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.WithdrawPayoutsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xChangeAddress** | **string** |  |  |
| **xAddress** | **string?** |  | [optional]  |
| **xCollateralUTxO** | **string?** |  | [optional]  |
| **postWithdrawalsRequest** | [**PostWithdrawalsRequest?**](PostWithdrawalsRequest?.md) |  | [optional]  |

### Return type

[**WithdrawPayoutsResponse**](WithdrawPayoutsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/vendor.iog.marlowe-runtime.withdraw-tx-json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** |  |  * X-Network-Id -  <br>  * X-Node-Tip -  <br>  * X-Runtime-Chain-Tip -  <br>  * X-Runtime-Tip -  <br>  * X-Runtime-Version -  <br>  |
| **400** | Invalid &#x60;X-Collateral-UTxO&#x60; or &#x60;X-Address&#x60; or &#x60;X-Change-Address&#x60; or &#x60;body&#x60; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

