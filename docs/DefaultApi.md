# MarloweAPIClient.Api.DefaultApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ContractsContractIdGet**](DefaultApi.md#contractscontractidget) | **GET** /contracts/{contractId} |  |
| [**ContractsContractIdNextGet**](DefaultApi.md#contractscontractidnextget) | **GET** /contracts/{contractId}/next |  |
| [**ContractsContractIdPut**](DefaultApi.md#contractscontractidput) | **PUT** /contracts/{contractId} |  |
| [**ContractsContractIdTransactionsGet**](DefaultApi.md#contractscontractidtransactionsget) | **GET** /contracts/{contractId}/transactions |  |
| [**ContractsContractIdTransactionsPost**](DefaultApi.md#contractscontractidtransactionspost) | **POST** /contracts/{contractId}/transactions |  |
| [**ContractsContractIdTransactionsTransactionIdGet**](DefaultApi.md#contractscontractidtransactionstransactionidget) | **GET** /contracts/{contractId}/transactions/{transactionId} |  |
| [**ContractsContractIdTransactionsTransactionIdPut**](DefaultApi.md#contractscontractidtransactionstransactionidput) | **PUT** /contracts/{contractId}/transactions/{transactionId} |  |
| [**ContractsGet**](DefaultApi.md#contractsget) | **GET** /contracts |  |
| [**ContractsPost**](DefaultApi.md#contractspost) | **POST** /contracts |  |
| [**ContractsSourcesContractSourceIdAdjacencyGet**](DefaultApi.md#contractssourcescontractsourceidadjacencyget) | **GET** /contracts/sources/{contractSourceId}/adjacency |  |
| [**ContractsSourcesContractSourceIdClosureGet**](DefaultApi.md#contractssourcescontractsourceidclosureget) | **GET** /contracts/sources/{contractSourceId}/closure |  |
| [**ContractsSourcesContractSourceIdGet**](DefaultApi.md#contractssourcescontractsourceidget) | **GET** /contracts/sources/{contractSourceId} |  |
| [**ContractsSourcesPost**](DefaultApi.md#contractssourcespost) | **POST** /contracts/sources |  |
| [**HealthcheckGet**](DefaultApi.md#healthcheckget) | **GET** /healthcheck |  |
| [**PayoutsGet**](DefaultApi.md#payoutsget) | **GET** /payouts |  |
| [**PayoutsPayoutIdGet**](DefaultApi.md#payoutspayoutidget) | **GET** /payouts/{payoutId} |  |
| [**WithdrawalsGet**](DefaultApi.md#withdrawalsget) | **GET** /withdrawals |  |
| [**WithdrawalsPost**](DefaultApi.md#withdrawalspost) | **POST** /withdrawals |  |
| [**WithdrawalsWithdrawalIdGet**](DefaultApi.md#withdrawalswithdrawalidget) | **GET** /withdrawals/{withdrawalId} |  |
| [**WithdrawalsWithdrawalIdPut**](DefaultApi.md#withdrawalswithdrawalidput) | **PUT** /withdrawals/{withdrawalId} |  |

<a id="contractscontractidget"></a>
# **ContractsContractIdGet**
> ContractsContractIdGet200Response ContractsContractIdGet (string contractId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarloweAPIClient.Api;
using MarloweAPIClient.Client;
using MarloweAPIClient.Model;

namespace Example
{
    public class ContractsContractIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(config);
            var contractId = 98d601c9307dd43307cf68a03aad0086d4e07a789b66919ccf9f7f7676577eb7%231;  // string | 

            try
            {
                ContractsContractIdGet200Response result = apiInstance.ContractsContractIdGet(contractId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ContractsContractIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContractsContractIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ContractsContractIdGet200Response> response = apiInstance.ContractsContractIdGetWithHttpInfo(contractId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ContractsContractIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contractId** | **string** |  |  |

### Return type

[**ContractsContractIdGet200Response**](ContractsContractIdGet200Response.md)

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

<a id="contractscontractidnextget"></a>
# **ContractsContractIdNextGet**
> Next ContractsContractIdNextGet (string contractId, string validityStart, string validityEnd, List<string>? party = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarloweAPIClient.Api;
using MarloweAPIClient.Client;
using MarloweAPIClient.Model;

namespace Example
{
    public class ContractsContractIdNextGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(config);
            var contractId = 98d601c9307dd43307cf68a03aad0086d4e07a789b66919ccf9f7f7676577eb7%231;  // string | 
            var validityStart = "validityStart_example";  // string | 
            var validityEnd = "validityEnd_example";  // string | 
            var party = new List<string>?(); // List<string>? |  (optional) 

            try
            {
                Next result = apiInstance.ContractsContractIdNextGet(contractId, validityStart, validityEnd, party);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ContractsContractIdNextGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContractsContractIdNextGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Next> response = apiInstance.ContractsContractIdNextGetWithHttpInfo(contractId, validityStart, validityEnd, party);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ContractsContractIdNextGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contractId** | **string** |  |  |
| **validityStart** | **string** |  |  |
| **validityEnd** | **string** |  |  |
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

<a id="contractscontractidput"></a>
# **ContractsContractIdPut**
> void ContractsContractIdPut (string contractId, TextEnvelope? textEnvelope = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarloweAPIClient.Api;
using MarloweAPIClient.Client;
using MarloweAPIClient.Model;

namespace Example
{
    public class ContractsContractIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(config);
            var contractId = 98d601c9307dd43307cf68a03aad0086d4e07a789b66919ccf9f7f7676577eb7%231;  // string | 
            var textEnvelope = new TextEnvelope?(); // TextEnvelope? |  (optional) 

            try
            {
                apiInstance.ContractsContractIdPut(contractId, textEnvelope);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ContractsContractIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContractsContractIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ContractsContractIdPutWithHttpInfo(contractId, textEnvelope);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ContractsContractIdPutWithHttpInfo: " + e.Message);
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

<a id="contractscontractidtransactionsget"></a>
# **ContractsContractIdTransactionsGet**
> ListObjectTxHeader ContractsContractIdTransactionsGet (string contractId, string? range = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarloweAPIClient.Api;
using MarloweAPIClient.Client;
using MarloweAPIClient.Model;

namespace Example
{
    public class ContractsContractIdTransactionsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(config);
            var contractId = 98d601c9307dd43307cf68a03aad0086d4e07a789b66919ccf9f7f7676577eb7%231;  // string | 
            var range = "range_example";  // string? |  (optional) 

            try
            {
                ListObjectTxHeader result = apiInstance.ContractsContractIdTransactionsGet(contractId, range);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ContractsContractIdTransactionsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContractsContractIdTransactionsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ListObjectTxHeader> response = apiInstance.ContractsContractIdTransactionsGetWithHttpInfo(contractId, range);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ContractsContractIdTransactionsGetWithHttpInfo: " + e.Message);
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

[**ListObjectTxHeader**](ListObjectTxHeader.md)

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

<a id="contractscontractidtransactionspost"></a>
# **ContractsContractIdTransactionsPost**
> ContractsContractIdTransactionsPost201Response ContractsContractIdTransactionsPost (string contractId, string xChangeAddress, string? xAddress = null, string? xCollateralUTxO = null, PostTransactionsRequest? postTransactionsRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarloweAPIClient.Api;
using MarloweAPIClient.Client;
using MarloweAPIClient.Model;

namespace Example
{
    public class ContractsContractIdTransactionsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(config);
            var contractId = 98d601c9307dd43307cf68a03aad0086d4e07a789b66919ccf9f7f7676577eb7%231;  // string | 
            var xChangeAddress = addr1w94f8ywk4fg672xasahtk4t9k6w3aql943uxz5rt62d4dvq8evxaf;  // string | 
            var xAddress = "xAddress_example";  // string? |  (optional) 
            var xCollateralUTxO = "xCollateralUTxO_example";  // string? |  (optional) 
            var postTransactionsRequest = new PostTransactionsRequest?(); // PostTransactionsRequest? |  (optional) 

            try
            {
                ContractsContractIdTransactionsPost201Response result = apiInstance.ContractsContractIdTransactionsPost(contractId, xChangeAddress, xAddress, xCollateralUTxO, postTransactionsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ContractsContractIdTransactionsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContractsContractIdTransactionsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ContractsContractIdTransactionsPost201Response> response = apiInstance.ContractsContractIdTransactionsPostWithHttpInfo(contractId, xChangeAddress, xAddress, xCollateralUTxO, postTransactionsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ContractsContractIdTransactionsPostWithHttpInfo: " + e.Message);
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

[**ContractsContractIdTransactionsPost201Response**](ContractsContractIdTransactionsPost201Response.md)

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

<a id="contractscontractidtransactionstransactionidget"></a>
# **ContractsContractIdTransactionsTransactionIdGet**
> ContractsContractIdTransactionsTransactionIdGet200Response ContractsContractIdTransactionsTransactionIdGet (string contractId, string transactionId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarloweAPIClient.Api;
using MarloweAPIClient.Client;
using MarloweAPIClient.Model;

namespace Example
{
    public class ContractsContractIdTransactionsTransactionIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(config);
            var contractId = 98d601c9307dd43307cf68a03aad0086d4e07a789b66919ccf9f7f7676577eb7%231;  // string | 
            var transactionId = "transactionId_example";  // string | 

            try
            {
                ContractsContractIdTransactionsTransactionIdGet200Response result = apiInstance.ContractsContractIdTransactionsTransactionIdGet(contractId, transactionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ContractsContractIdTransactionsTransactionIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContractsContractIdTransactionsTransactionIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ContractsContractIdTransactionsTransactionIdGet200Response> response = apiInstance.ContractsContractIdTransactionsTransactionIdGetWithHttpInfo(contractId, transactionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ContractsContractIdTransactionsTransactionIdGetWithHttpInfo: " + e.Message);
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

[**ContractsContractIdTransactionsTransactionIdGet200Response**](ContractsContractIdTransactionsTransactionIdGet200Response.md)

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

<a id="contractscontractidtransactionstransactionidput"></a>
# **ContractsContractIdTransactionsTransactionIdPut**
> void ContractsContractIdTransactionsTransactionIdPut (string contractId, string transactionId, TextEnvelope? textEnvelope = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarloweAPIClient.Api;
using MarloweAPIClient.Client;
using MarloweAPIClient.Model;

namespace Example
{
    public class ContractsContractIdTransactionsTransactionIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(config);
            var contractId = 98d601c9307dd43307cf68a03aad0086d4e07a789b66919ccf9f7f7676577eb7%231;  // string | 
            var transactionId = "transactionId_example";  // string | 
            var textEnvelope = new TextEnvelope?(); // TextEnvelope? |  (optional) 

            try
            {
                apiInstance.ContractsContractIdTransactionsTransactionIdPut(contractId, transactionId, textEnvelope);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ContractsContractIdTransactionsTransactionIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContractsContractIdTransactionsTransactionIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.ContractsContractIdTransactionsTransactionIdPutWithHttpInfo(contractId, transactionId, textEnvelope);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ContractsContractIdTransactionsTransactionIdPutWithHttpInfo: " + e.Message);
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

<a id="contractsget"></a>
# **ContractsGet**
> ListObjectContractHeader ContractsGet (List<string>? roleCurrency = null, List<string>? tag = null, List<string>? partyAddress = null, List<string>? partyRole = null, string? range = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarloweAPIClient.Api;
using MarloweAPIClient.Client;
using MarloweAPIClient.Model;

namespace Example
{
    public class ContractsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(config);
            var roleCurrency = new List<string>?(); // List<string>? |  (optional) 
            var tag = new List<string>?(); // List<string>? |  (optional) 
            var partyAddress = new List<string>?(); // List<string>? |  (optional) 
            var partyRole = new List<string>?(); // List<string>? |  (optional) 
            var range = "range_example";  // string? |  (optional) 

            try
            {
                ListObjectContractHeader result = apiInstance.ContractsGet(roleCurrency, tag, partyAddress, partyRole, range);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ContractsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContractsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ListObjectContractHeader> response = apiInstance.ContractsGetWithHttpInfo(roleCurrency, tag, partyAddress, partyRole, range);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ContractsGetWithHttpInfo: " + e.Message);
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

[**ListObjectContractHeader**](ListObjectContractHeader.md)

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

<a id="contractspost"></a>
# **ContractsPost**
> ContractsPost201Response ContractsPost (string xChangeAddress, string? xStakeAddress = null, string? xAddress = null, string? xCollateralUTxO = null, PostContractsRequest? postContractsRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarloweAPIClient.Api;
using MarloweAPIClient.Client;
using MarloweAPIClient.Model;

namespace Example
{
    public class ContractsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(config);
            var xChangeAddress = addr1w94f8ywk4fg672xasahtk4t9k6w3aql943uxz5rt62d4dvq8evxaf;  // string | 
            var xStakeAddress = stake1ux7lyy9nhecm033qsmel9awnr22up6jadlzkrxufr78w82gsfsn0d;  // string? |  (optional) 
            var xAddress = "xAddress_example";  // string? |  (optional) 
            var xCollateralUTxO = "xCollateralUTxO_example";  // string? |  (optional) 
            var postContractsRequest = new PostContractsRequest?(); // PostContractsRequest? |  (optional) 

            try
            {
                ContractsPost201Response result = apiInstance.ContractsPost(xChangeAddress, xStakeAddress, xAddress, xCollateralUTxO, postContractsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ContractsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContractsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ContractsPost201Response> response = apiInstance.ContractsPostWithHttpInfo(xChangeAddress, xStakeAddress, xAddress, xCollateralUTxO, postContractsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ContractsPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xChangeAddress** | **string** |  |  |
| **xStakeAddress** | **string?** |  | [optional]  |
| **xAddress** | **string?** |  | [optional]  |
| **xCollateralUTxO** | **string?** |  | [optional]  |
| **postContractsRequest** | [**PostContractsRequest?**](PostContractsRequest?.md) |  | [optional]  |

### Return type

[**ContractsPost201Response**](ContractsPost201Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/vendor.iog.marlowe-runtime.contract-tx-json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** |  |  * X-Network-Id -  <br>  * X-Node-Tip -  <br>  * X-Runtime-Chain-Tip -  <br>  * X-Runtime-Tip -  <br>  * X-Runtime-Version -  <br>  |
| **400** | Invalid &#x60;X-Collateral-UTxO&#x60; or &#x60;X-Address&#x60; or &#x60;X-Change-Address&#x60; or &#x60;X-Stake-Address&#x60; or &#x60;body&#x60; |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="contractssourcescontractsourceidadjacencyget"></a>
# **ContractsSourcesContractSourceIdAdjacencyGet**
> ListObjectContractSourceId ContractsSourcesContractSourceIdAdjacencyGet (string contractSourceId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarloweAPIClient.Api;
using MarloweAPIClient.Client;
using MarloweAPIClient.Model;

namespace Example
{
    public class ContractsSourcesContractSourceIdAdjacencyGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(config);
            var contractSourceId = "contractSourceId_example";  // string | 

            try
            {
                ListObjectContractSourceId result = apiInstance.ContractsSourcesContractSourceIdAdjacencyGet(contractSourceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ContractsSourcesContractSourceIdAdjacencyGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContractsSourcesContractSourceIdAdjacencyGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ListObjectContractSourceId> response = apiInstance.ContractsSourcesContractSourceIdAdjacencyGetWithHttpInfo(contractSourceId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ContractsSourcesContractSourceIdAdjacencyGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contractSourceId** | **string** |  |  |

### Return type

[**ListObjectContractSourceId**](ListObjectContractSourceId.md)

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

<a id="contractssourcescontractsourceidclosureget"></a>
# **ContractsSourcesContractSourceIdClosureGet**
> ListObjectContractSourceId ContractsSourcesContractSourceIdClosureGet (string contractSourceId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarloweAPIClient.Api;
using MarloweAPIClient.Client;
using MarloweAPIClient.Model;

namespace Example
{
    public class ContractsSourcesContractSourceIdClosureGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(config);
            var contractSourceId = "contractSourceId_example";  // string | 

            try
            {
                ListObjectContractSourceId result = apiInstance.ContractsSourcesContractSourceIdClosureGet(contractSourceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ContractsSourcesContractSourceIdClosureGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContractsSourcesContractSourceIdClosureGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ListObjectContractSourceId> response = apiInstance.ContractsSourcesContractSourceIdClosureGetWithHttpInfo(contractSourceId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ContractsSourcesContractSourceIdClosureGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contractSourceId** | **string** |  |  |

### Return type

[**ListObjectContractSourceId**](ListObjectContractSourceId.md)

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

<a id="contractssourcescontractsourceidget"></a>
# **ContractsSourcesContractSourceIdGet**
> Contract ContractsSourcesContractSourceIdGet (string contractSourceId, bool? expand = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarloweAPIClient.Api;
using MarloweAPIClient.Client;
using MarloweAPIClient.Model;

namespace Example
{
    public class ContractsSourcesContractSourceIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(config);
            var contractSourceId = "contractSourceId_example";  // string | 
            var expand = false;  // bool? |  (optional)  (default to false)

            try
            {
                Contract result = apiInstance.ContractsSourcesContractSourceIdGet(contractSourceId, expand);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ContractsSourcesContractSourceIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContractsSourcesContractSourceIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Contract> response = apiInstance.ContractsSourcesContractSourceIdGetWithHttpInfo(contractSourceId, expand);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ContractsSourcesContractSourceIdGetWithHttpInfo: " + e.Message);
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

<a id="contractssourcespost"></a>
# **ContractsSourcesPost**
> PostContractSourceResponse ContractsSourcesPost (string main, List<LabelledObject>? labelledObject = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarloweAPIClient.Api;
using MarloweAPIClient.Client;
using MarloweAPIClient.Model;

namespace Example
{
    public class ContractsSourcesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(config);
            var main = "main_example";  // string | 
            var labelledObject = new List<LabelledObject>?(); // List<LabelledObject>? |  (optional) 

            try
            {
                PostContractSourceResponse result = apiInstance.ContractsSourcesPost(main, labelledObject);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ContractsSourcesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ContractsSourcesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PostContractSourceResponse> response = apiInstance.ContractsSourcesPostWithHttpInfo(main, labelledObject);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ContractsSourcesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **main** | **string** |  |  |
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

<a id="healthcheckget"></a>
# **HealthcheckGet**
> void HealthcheckGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarloweAPIClient.Api;
using MarloweAPIClient.Client;
using MarloweAPIClient.Model;

namespace Example
{
    public class HealthcheckGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(config);

            try
            {
                apiInstance.HealthcheckGet();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.HealthcheckGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HealthcheckGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.HealthcheckGetWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.HealthcheckGetWithHttpInfo: " + e.Message);
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

<a id="payoutsget"></a>
# **PayoutsGet**
> ListObjectPayoutHeader PayoutsGet (List<string>? contractId = null, List<string>? roleToken = null, string? status = null, string? range = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarloweAPIClient.Api;
using MarloweAPIClient.Client;
using MarloweAPIClient.Model;

namespace Example
{
    public class PayoutsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(config);
            var contractId = new List<string>?(); // List<string>? |  (optional) 
            var roleToken = new List<string>?(); // List<string>? |  (optional) 
            var status = "available";  // string? |  (optional) 
            var range = "range_example";  // string? |  (optional) 

            try
            {
                ListObjectPayoutHeader result = apiInstance.PayoutsGet(contractId, roleToken, status, range);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.PayoutsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PayoutsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ListObjectPayoutHeader> response = apiInstance.PayoutsGetWithHttpInfo(contractId, roleToken, status, range);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.PayoutsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contractId** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **roleToken** | [**List&lt;string&gt;?**](string.md) |  | [optional]  |
| **status** | **string?** |  | [optional]  |
| **range** | **string?** |  | [optional]  |

### Return type

[**ListObjectPayoutHeader**](ListObjectPayoutHeader.md)

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

<a id="payoutspayoutidget"></a>
# **PayoutsPayoutIdGet**
> PayoutsPayoutIdGet200Response PayoutsPayoutIdGet (string payoutId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarloweAPIClient.Api;
using MarloweAPIClient.Client;
using MarloweAPIClient.Model;

namespace Example
{
    public class PayoutsPayoutIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(config);
            var payoutId = 98d601c9307dd43307cf68a03aad0086d4e07a789b66919ccf9f7f7676577eb7%231;  // string | 

            try
            {
                PayoutsPayoutIdGet200Response result = apiInstance.PayoutsPayoutIdGet(payoutId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.PayoutsPayoutIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PayoutsPayoutIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<PayoutsPayoutIdGet200Response> response = apiInstance.PayoutsPayoutIdGetWithHttpInfo(payoutId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.PayoutsPayoutIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **payoutId** | **string** |  |  |

### Return type

[**PayoutsPayoutIdGet200Response**](PayoutsPayoutIdGet200Response.md)

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

<a id="withdrawalsget"></a>
# **WithdrawalsGet**
> ListObjectWithdrawalHeader WithdrawalsGet (List<string>? roleCurrency = null, string? range = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarloweAPIClient.Api;
using MarloweAPIClient.Client;
using MarloweAPIClient.Model;

namespace Example
{
    public class WithdrawalsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(config);
            var roleCurrency = new List<string>?(); // List<string>? |  (optional) 
            var range = "range_example";  // string? |  (optional) 

            try
            {
                ListObjectWithdrawalHeader result = apiInstance.WithdrawalsGet(roleCurrency, range);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.WithdrawalsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WithdrawalsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ListObjectWithdrawalHeader> response = apiInstance.WithdrawalsGetWithHttpInfo(roleCurrency, range);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.WithdrawalsGetWithHttpInfo: " + e.Message);
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

[**ListObjectWithdrawalHeader**](ListObjectWithdrawalHeader.md)

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

<a id="withdrawalspost"></a>
# **WithdrawalsPost**
> WithdrawalsPost201Response WithdrawalsPost (string xChangeAddress, string? xAddress = null, string? xCollateralUTxO = null, PostWithdrawalsRequest? postWithdrawalsRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarloweAPIClient.Api;
using MarloweAPIClient.Client;
using MarloweAPIClient.Model;

namespace Example
{
    public class WithdrawalsPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(config);
            var xChangeAddress = addr1w94f8ywk4fg672xasahtk4t9k6w3aql943uxz5rt62d4dvq8evxaf;  // string | 
            var xAddress = "xAddress_example";  // string? |  (optional) 
            var xCollateralUTxO = "xCollateralUTxO_example";  // string? |  (optional) 
            var postWithdrawalsRequest = new PostWithdrawalsRequest?(); // PostWithdrawalsRequest? |  (optional) 

            try
            {
                WithdrawalsPost201Response result = apiInstance.WithdrawalsPost(xChangeAddress, xAddress, xCollateralUTxO, postWithdrawalsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.WithdrawalsPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WithdrawalsPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<WithdrawalsPost201Response> response = apiInstance.WithdrawalsPostWithHttpInfo(xChangeAddress, xAddress, xCollateralUTxO, postWithdrawalsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.WithdrawalsPostWithHttpInfo: " + e.Message);
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

[**WithdrawalsPost201Response**](WithdrawalsPost201Response.md)

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

<a id="withdrawalswithdrawalidget"></a>
# **WithdrawalsWithdrawalIdGet**
> Withdrawal WithdrawalsWithdrawalIdGet (string withdrawalId)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarloweAPIClient.Api;
using MarloweAPIClient.Client;
using MarloweAPIClient.Model;

namespace Example
{
    public class WithdrawalsWithdrawalIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(config);
            var withdrawalId = "withdrawalId_example";  // string | 

            try
            {
                Withdrawal result = apiInstance.WithdrawalsWithdrawalIdGet(withdrawalId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.WithdrawalsWithdrawalIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WithdrawalsWithdrawalIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Withdrawal> response = apiInstance.WithdrawalsWithdrawalIdGetWithHttpInfo(withdrawalId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.WithdrawalsWithdrawalIdGetWithHttpInfo: " + e.Message);
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

<a id="withdrawalswithdrawalidput"></a>
# **WithdrawalsWithdrawalIdPut**
> void WithdrawalsWithdrawalIdPut (string withdrawalId, TextEnvelope? textEnvelope = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarloweAPIClient.Api;
using MarloweAPIClient.Client;
using MarloweAPIClient.Model;

namespace Example
{
    public class WithdrawalsWithdrawalIdPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new DefaultApi(config);
            var withdrawalId = "withdrawalId_example";  // string | 
            var textEnvelope = new TextEnvelope?(); // TextEnvelope? |  (optional) 

            try
            {
                apiInstance.WithdrawalsWithdrawalIdPut(withdrawalId, textEnvelope);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.WithdrawalsWithdrawalIdPut: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the WithdrawalsWithdrawalIdPutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.WithdrawalsWithdrawalIdPutWithHttpInfo(withdrawalId, textEnvelope);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.WithdrawalsWithdrawalIdPutWithHttpInfo: " + e.Message);
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

