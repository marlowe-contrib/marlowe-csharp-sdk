# MarloweAPIClient - the C# library for the 

No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 
- SDK version: 1.0.0
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen

<a id="frameworks-supported"></a>
## Frameworks supported

<a id="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.13.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 13.0.2 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

<a id="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using MarloweAPIClient.Api;
using MarloweAPIClient.Client;
using MarloweAPIClient.Model;
```
<a id="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out MarloweAPIClient.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a id="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a id="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using MarloweAPIClient.Api;
using MarloweAPIClient.Client;
using MarloweAPIClient.Model;

namespace Example
{
    public class Example
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
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.ContractsContractIdGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a id="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *http://localhost*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*DefaultApi* | [**ContractsContractIdGet**](docs/DefaultApi.md#contractscontractidget) | **GET** /contracts/{contractId} | 
*DefaultApi* | [**ContractsContractIdNextGet**](docs/DefaultApi.md#contractscontractidnextget) | **GET** /contracts/{contractId}/next | 
*DefaultApi* | [**ContractsContractIdPut**](docs/DefaultApi.md#contractscontractidput) | **PUT** /contracts/{contractId} | 
*DefaultApi* | [**ContractsContractIdTransactionsGet**](docs/DefaultApi.md#contractscontractidtransactionsget) | **GET** /contracts/{contractId}/transactions | 
*DefaultApi* | [**ContractsContractIdTransactionsPost**](docs/DefaultApi.md#contractscontractidtransactionspost) | **POST** /contracts/{contractId}/transactions | 
*DefaultApi* | [**ContractsContractIdTransactionsTransactionIdGet**](docs/DefaultApi.md#contractscontractidtransactionstransactionidget) | **GET** /contracts/{contractId}/transactions/{transactionId} | 
*DefaultApi* | [**ContractsContractIdTransactionsTransactionIdPut**](docs/DefaultApi.md#contractscontractidtransactionstransactionidput) | **PUT** /contracts/{contractId}/transactions/{transactionId} | 
*DefaultApi* | [**ContractsGet**](docs/DefaultApi.md#contractsget) | **GET** /contracts | 
*DefaultApi* | [**ContractsPost**](docs/DefaultApi.md#contractspost) | **POST** /contracts | 
*DefaultApi* | [**ContractsSourcesContractSourceIdAdjacencyGet**](docs/DefaultApi.md#contractssourcescontractsourceidadjacencyget) | **GET** /contracts/sources/{contractSourceId}/adjacency | 
*DefaultApi* | [**ContractsSourcesContractSourceIdClosureGet**](docs/DefaultApi.md#contractssourcescontractsourceidclosureget) | **GET** /contracts/sources/{contractSourceId}/closure | 
*DefaultApi* | [**ContractsSourcesContractSourceIdGet**](docs/DefaultApi.md#contractssourcescontractsourceidget) | **GET** /contracts/sources/{contractSourceId} | 
*DefaultApi* | [**ContractsSourcesPost**](docs/DefaultApi.md#contractssourcespost) | **POST** /contracts/sources | 
*DefaultApi* | [**HealthcheckGet**](docs/DefaultApi.md#healthcheckget) | **GET** /healthcheck | 
*DefaultApi* | [**PayoutsGet**](docs/DefaultApi.md#payoutsget) | **GET** /payouts | 
*DefaultApi* | [**PayoutsPayoutIdGet**](docs/DefaultApi.md#payoutspayoutidget) | **GET** /payouts/{payoutId} | 
*DefaultApi* | [**WithdrawalsGet**](docs/DefaultApi.md#withdrawalsget) | **GET** /withdrawals | 
*DefaultApi* | [**WithdrawalsPost**](docs/DefaultApi.md#withdrawalspost) | **POST** /withdrawals | 
*DefaultApi* | [**WithdrawalsWithdrawalIdGet**](docs/DefaultApi.md#withdrawalswithdrawalidget) | **GET** /withdrawals/{withdrawalId} | 
*DefaultApi* | [**WithdrawalsWithdrawalIdPut**](docs/DefaultApi.md#withdrawalswithdrawalidput) | **PUT** /withdrawals/{withdrawalId} | 


<a id="documentation-for-models"></a>
## Documentation for Models

 - [Model.Action](docs/Action.md)
 - [Model.ActionObject](docs/ActionObject.md)
 - [Model.ActionOneOf](docs/ActionOneOf.md)
 - [Model.ActionOneOf1](docs/ActionOneOf1.md)
 - [Model.ActionOneOf2](docs/ActionOneOf2.md)
 - [Model.ApplicableInputs](docs/ApplicableInputs.md)
 - [Model.ApplyInputsTxEnvelope](docs/ApplyInputsTxEnvelope.md)
 - [Model.AssetId](docs/AssetId.md)
 - [Model.Assets](docs/Assets.md)
 - [Model.BlockHeader](docs/BlockHeader.md)
 - [Model.Bound](docs/Bound.md)
 - [Model.CanChoose](docs/CanChoose.md)
 - [Model.CanDeposit](docs/CanDeposit.md)
 - [Model.CanNotify](docs/CanNotify.md)
 - [Model.Case](docs/Case.md)
 - [Model.CaseObject](docs/CaseObject.md)
 - [Model.CaseObjectOneOf](docs/CaseObjectOneOf.md)
 - [Model.CaseObjectOneOf1](docs/CaseObjectOneOf1.md)
 - [Model.CaseOneOf](docs/CaseOneOf.md)
 - [Model.CaseOneOf1](docs/CaseOneOf1.md)
 - [Model.ChoiceId](docs/ChoiceId.md)
 - [Model.ChoiceIdObject](docs/ChoiceIdObject.md)
 - [Model.Contract](docs/Contract.md)
 - [Model.ContractHeader](docs/ContractHeader.md)
 - [Model.ContractObject](docs/ContractObject.md)
 - [Model.ContractObjectOneOf](docs/ContractObjectOneOf.md)
 - [Model.ContractObjectOneOf1](docs/ContractObjectOneOf1.md)
 - [Model.ContractObjectOneOf2](docs/ContractObjectOneOf2.md)
 - [Model.ContractObjectOneOf3](docs/ContractObjectOneOf3.md)
 - [Model.ContractObjectOneOf4](docs/ContractObjectOneOf4.md)
 - [Model.ContractOneOf](docs/ContractOneOf.md)
 - [Model.ContractOneOf1](docs/ContractOneOf1.md)
 - [Model.ContractOneOf2](docs/ContractOneOf2.md)
 - [Model.ContractOneOf3](docs/ContractOneOf3.md)
 - [Model.ContractOneOf4](docs/ContractOneOf4.md)
 - [Model.ContractState](docs/ContractState.md)
 - [Model.ContractsContractIdGet200Response](docs/ContractsContractIdGet200Response.md)
 - [Model.ContractsContractIdGet200ResponseLinks](docs/ContractsContractIdGet200ResponseLinks.md)
 - [Model.ContractsContractIdTransactionsPost201Response](docs/ContractsContractIdTransactionsPost201Response.md)
 - [Model.ContractsContractIdTransactionsPost201ResponseLinks](docs/ContractsContractIdTransactionsPost201ResponseLinks.md)
 - [Model.ContractsContractIdTransactionsTransactionIdGet200Response](docs/ContractsContractIdTransactionsTransactionIdGet200Response.md)
 - [Model.ContractsContractIdTransactionsTransactionIdGet200ResponseLinks](docs/ContractsContractIdTransactionsTransactionIdGet200ResponseLinks.md)
 - [Model.ContractsPost201Response](docs/ContractsPost201Response.md)
 - [Model.ContractsPost201ResponseLinks](docs/ContractsPost201ResponseLinks.md)
 - [Model.ExBudget](docs/ExBudget.md)
 - [Model.Input](docs/Input.md)
 - [Model.InputOneOf](docs/InputOneOf.md)
 - [Model.InputOneOf1](docs/InputOneOf1.md)
 - [Model.InputOneOf2](docs/InputOneOf2.md)
 - [Model.InputOneOf3](docs/InputOneOf3.md)
 - [Model.InputOneOf4](docs/InputOneOf4.md)
 - [Model.IntervalError](docs/IntervalError.md)
 - [Model.IntervalErrorOneOf](docs/IntervalErrorOneOf.md)
 - [Model.IntervalErrorOneOf1](docs/IntervalErrorOneOf1.md)
 - [Model.IntervalErrorOneOf1IntervalInPastError](docs/IntervalErrorOneOf1IntervalInPastError.md)
 - [Model.IntervalErrorOneOfInvalidInterval](docs/IntervalErrorOneOfInvalidInterval.md)
 - [Model.LabelledObject](docs/LabelledObject.md)
 - [Model.LabelledObjectValue](docs/LabelledObjectValue.md)
 - [Model.ListObjectContractHeader](docs/ListObjectContractHeader.md)
 - [Model.ListObjectContractHeaderResultsInner](docs/ListObjectContractHeaderResultsInner.md)
 - [Model.ListObjectContractHeaderResultsInnerLinks](docs/ListObjectContractHeaderResultsInnerLinks.md)
 - [Model.ListObjectContractSourceId](docs/ListObjectContractSourceId.md)
 - [Model.ListObjectPayoutHeader](docs/ListObjectPayoutHeader.md)
 - [Model.ListObjectPayoutHeaderResultsInner](docs/ListObjectPayoutHeaderResultsInner.md)
 - [Model.ListObjectPayoutHeaderResultsInnerLinks](docs/ListObjectPayoutHeaderResultsInnerLinks.md)
 - [Model.ListObjectTxHeader](docs/ListObjectTxHeader.md)
 - [Model.ListObjectTxHeaderResultsInner](docs/ListObjectTxHeaderResultsInner.md)
 - [Model.ListObjectWithdrawalHeader](docs/ListObjectWithdrawalHeader.md)
 - [Model.ListObjectWithdrawalHeaderResultsInner](docs/ListObjectWithdrawalHeaderResultsInner.md)
 - [Model.MarloweState](docs/MarloweState.md)
 - [Model.MarloweStateAccountsInnerInner](docs/MarloweStateAccountsInnerInner.md)
 - [Model.MarloweStateAccountsInnerInnerOneOfInner](docs/MarloweStateAccountsInnerInnerOneOfInner.md)
 - [Model.MarloweStateBoundValuesInnerInner](docs/MarloweStateBoundValuesInnerInner.md)
 - [Model.MarloweStateChoicesInnerInner](docs/MarloweStateChoicesInnerInner.md)
 - [Model.MarloweVersion](docs/MarloweVersion.md)
 - [Model.Next](docs/Next.md)
 - [Model.Observation](docs/Observation.md)
 - [Model.ObservationObject](docs/ObservationObject.md)
 - [Model.ObservationObjectOneOf](docs/ObservationObjectOneOf.md)
 - [Model.ObservationObjectOneOf1](docs/ObservationObjectOneOf1.md)
 - [Model.ObservationObjectOneOf2](docs/ObservationObjectOneOf2.md)
 - [Model.ObservationObjectOneOf3](docs/ObservationObjectOneOf3.md)
 - [Model.ObservationObjectOneOf4](docs/ObservationObjectOneOf4.md)
 - [Model.ObservationObjectOneOf5](docs/ObservationObjectOneOf5.md)
 - [Model.ObservationObjectOneOf6](docs/ObservationObjectOneOf6.md)
 - [Model.ObservationObjectOneOf7](docs/ObservationObjectOneOf7.md)
 - [Model.ObservationObjectOneOf8](docs/ObservationObjectOneOf8.md)
 - [Model.ObservationOneOf](docs/ObservationOneOf.md)
 - [Model.ObservationOneOf1](docs/ObservationOneOf1.md)
 - [Model.ObservationOneOf2](docs/ObservationOneOf2.md)
 - [Model.ObservationOneOf3](docs/ObservationOneOf3.md)
 - [Model.ObservationOneOf4](docs/ObservationOneOf4.md)
 - [Model.ObservationOneOf5](docs/ObservationOneOf5.md)
 - [Model.ObservationOneOf6](docs/ObservationOneOf6.md)
 - [Model.ObservationOneOf7](docs/ObservationOneOf7.md)
 - [Model.ObservationOneOf8](docs/ObservationOneOf8.md)
 - [Model.Party](docs/Party.md)
 - [Model.PartyObject](docs/PartyObject.md)
 - [Model.PartyOneOf](docs/PartyOneOf.md)
 - [Model.PartyOneOf1](docs/PartyOneOf1.md)
 - [Model.Payee](docs/Payee.md)
 - [Model.PayeeObject](docs/PayeeObject.md)
 - [Model.PayeeObjectOneOf](docs/PayeeObjectOneOf.md)
 - [Model.PayeeObjectOneOf1](docs/PayeeObjectOneOf1.md)
 - [Model.PayeeOneOf](docs/PayeeOneOf.md)
 - [Model.PayeeOneOf1](docs/PayeeOneOf1.md)
 - [Model.Payment](docs/Payment.md)
 - [Model.Payout](docs/Payout.md)
 - [Model.PayoutHeader](docs/PayoutHeader.md)
 - [Model.PayoutState](docs/PayoutState.md)
 - [Model.PayoutStatus](docs/PayoutStatus.md)
 - [Model.PayoutsPayoutIdGet200Response](docs/PayoutsPayoutIdGet200Response.md)
 - [Model.PayoutsPayoutIdGet200ResponseLinks](docs/PayoutsPayoutIdGet200ResponseLinks.md)
 - [Model.PlutusAddress](docs/PlutusAddress.md)
 - [Model.PlutusCredential](docs/PlutusCredential.md)
 - [Model.PlutusCredentialOneOf](docs/PlutusCredentialOneOf.md)
 - [Model.PlutusCredentialOneOf1](docs/PlutusCredentialOneOf1.md)
 - [Model.PlutusStakingCredential](docs/PlutusStakingCredential.md)
 - [Model.PlutusStakingCredentialOneOf](docs/PlutusStakingCredentialOneOf.md)
 - [Model.PlutusStakingCredentialOneOf1](docs/PlutusStakingCredentialOneOf1.md)
 - [Model.PlutusStakingCredentialOneOf1StakingHashInner](docs/PlutusStakingCredentialOneOf1StakingHashInner.md)
 - [Model.PostContractSourceResponse](docs/PostContractSourceResponse.md)
 - [Model.PostContractsRequest](docs/PostContractsRequest.md)
 - [Model.PostContractsRequestContract](docs/PostContractsRequestContract.md)
 - [Model.PostTransactionsRequest](docs/PostTransactionsRequest.md)
 - [Model.PostWithdrawalsRequest](docs/PostWithdrawalsRequest.md)
 - [Model.RoleTokenConfig](docs/RoleTokenConfig.md)
 - [Model.RoleTokenConfigOneOf](docs/RoleTokenConfigOneOf.md)
 - [Model.RolesConfig](docs/RolesConfig.md)
 - [Model.SafetyError](docs/SafetyError.md)
 - [Model.TextEnvelope](docs/TextEnvelope.md)
 - [Model.Token](docs/Token.md)
 - [Model.TokenMetadata](docs/TokenMetadata.md)
 - [Model.TokenMetadataFile](docs/TokenMetadataFile.md)
 - [Model.TokenObject](docs/TokenObject.md)
 - [Model.Transaction](docs/Transaction.md)
 - [Model.TransactionError](docs/TransactionError.md)
 - [Model.TransactionErrorOneOf](docs/TransactionErrorOneOf.md)
 - [Model.TransactionInput](docs/TransactionInput.md)
 - [Model.TransactionInputTxInterval](docs/TransactionInputTxInterval.md)
 - [Model.TransactionOutput](docs/TransactionOutput.md)
 - [Model.TransactionOutputOneOf](docs/TransactionOutputOneOf.md)
 - [Model.TransactionOutputOneOf1](docs/TransactionOutputOneOf1.md)
 - [Model.TransactionWarning](docs/TransactionWarning.md)
 - [Model.TransactionWarningOneOf](docs/TransactionWarningOneOf.md)
 - [Model.TransactionWarningOneOf1](docs/TransactionWarningOneOf1.md)
 - [Model.TransactionWarningOneOf2](docs/TransactionWarningOneOf2.md)
 - [Model.TransactionWarningOneOf3](docs/TransactionWarningOneOf3.md)
 - [Model.Tx](docs/Tx.md)
 - [Model.TxHeader](docs/TxHeader.md)
 - [Model.TxStatus](docs/TxStatus.md)
 - [Model.Value](docs/Value.md)
 - [Model.ValueObject](docs/ValueObject.md)
 - [Model.ValueObjectOneOf](docs/ValueObjectOneOf.md)
 - [Model.ValueObjectOneOf1](docs/ValueObjectOneOf1.md)
 - [Model.ValueObjectOneOf2](docs/ValueObjectOneOf2.md)
 - [Model.ValueObjectOneOf3](docs/ValueObjectOneOf3.md)
 - [Model.ValueObjectOneOf4](docs/ValueObjectOneOf4.md)
 - [Model.ValueObjectOneOf5](docs/ValueObjectOneOf5.md)
 - [Model.ValueObjectOneOf6](docs/ValueObjectOneOf6.md)
 - [Model.ValueObjectOneOf7](docs/ValueObjectOneOf7.md)
 - [Model.ValueObjectOneOf8](docs/ValueObjectOneOf8.md)
 - [Model.ValueOneOf](docs/ValueOneOf.md)
 - [Model.ValueOneOf1](docs/ValueOneOf1.md)
 - [Model.ValueOneOf2](docs/ValueOneOf2.md)
 - [Model.ValueOneOf3](docs/ValueOneOf3.md)
 - [Model.ValueOneOf4](docs/ValueOneOf4.md)
 - [Model.ValueOneOf5](docs/ValueOneOf5.md)
 - [Model.ValueOneOf6](docs/ValueOneOf6.md)
 - [Model.ValueOneOf7](docs/ValueOneOf7.md)
 - [Model.ValueOneOf8](docs/ValueOneOf8.md)
 - [Model.Withdrawal](docs/Withdrawal.md)
 - [Model.WithdrawalHeader](docs/WithdrawalHeader.md)
 - [Model.WithdrawalsPost201Response](docs/WithdrawalsPost201Response.md)
 - [Model.WithdrawalsPost201ResponseLinks](docs/WithdrawalsPost201ResponseLinks.md)


<a id="documentation-for-authorization"></a>
## Documentation for Authorization

Endpoints do not require authorization.

