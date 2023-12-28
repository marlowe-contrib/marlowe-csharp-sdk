# MarloweAPIClient - the C# library for the Marlowe Runtime REST API

REST API for Marlowe Runtime

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 0.0.5.1
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
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.ApplyInputsToContract: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a id="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://marlowe-runtime-preprod-web.scdev.aws.iohkdev.io*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*DefaultApi* | [**ApplyInputsToContract**](docs/DefaultApi.md#applyinputstocontract) | **POST** /contracts/{contractId}/transactions | Apply inputs to contract
*DefaultApi* | [**CreateContract**](docs/DefaultApi.md#createcontract) | **POST** /contracts | Create a new contract
*DefaultApi* | [**CreateContractSources**](docs/DefaultApi.md#createcontractsources) | **POST** /contracts/sources | Upload contract sources
*DefaultApi* | [**GetContractById**](docs/DefaultApi.md#getcontractbyid) | **GET** /contracts/{contractId} | Get contract by ID
*DefaultApi* | [**GetContractSourceAdjacency**](docs/DefaultApi.md#getcontractsourceadjacency) | **GET** /contracts/sources/{contractSourceId}/adjacency | Get adjacent contract source IDs by ID
*DefaultApi* | [**GetContractSourceById**](docs/DefaultApi.md#getcontractsourcebyid) | **GET** /contracts/sources/{contractSourceId} | Get contract source by ID
*DefaultApi* | [**GetContractSourceClosure**](docs/DefaultApi.md#getcontractsourceclosure) | **GET** /contracts/sources/{contractSourceId}/closure | Get contract source closure by ID
*DefaultApi* | [**GetContractTransactionById**](docs/DefaultApi.md#getcontracttransactionbyid) | **GET** /contracts/{contractId}/transactions/{transactionId} | Get contract transaction by ID
*DefaultApi* | [**GetContracts**](docs/DefaultApi.md#getcontracts) | **GET** /contracts | Get contracts
*DefaultApi* | [**GetNextStepsForContract**](docs/DefaultApi.md#getnextstepsforcontract) | **GET** /contracts/{contractId}/next | Get next contract steps
*DefaultApi* | [**GetPayoutById**](docs/DefaultApi.md#getpayoutbyid) | **GET** /payouts/{payoutId} | Get payout by ID
*DefaultApi* | [**GetPayouts**](docs/DefaultApi.md#getpayouts) | **GET** /payouts | Get role payouts
*DefaultApi* | [**GetTransactionsForContract**](docs/DefaultApi.md#gettransactionsforcontract) | **GET** /contracts/{contractId}/transactions | Get transactions for contract
*DefaultApi* | [**GetWithdrawalById**](docs/DefaultApi.md#getwithdrawalbyid) | **GET** /withdrawals/{withdrawalId} | Get withdrawal by ID
*DefaultApi* | [**GetWithdrawals**](docs/DefaultApi.md#getwithdrawals) | **GET** /withdrawals | Get withdrawals
*DefaultApi* | [**Healthcheck**](docs/DefaultApi.md#healthcheck) | **GET** /healthcheck | Test server status
*DefaultApi* | [**SubmitContract**](docs/DefaultApi.md#submitcontract) | **PUT** /contracts/{contractId} | Submit contract to chain
*DefaultApi* | [**SubmitContractTransaction**](docs/DefaultApi.md#submitcontracttransaction) | **PUT** /contracts/{contractId}/transactions/{transactionId} | Submit contract input application
*DefaultApi* | [**SubmitWithdrawal**](docs/DefaultApi.md#submitwithdrawal) | **PUT** /withdrawals/{withdrawalId} | Submit payout withdrawal
*DefaultApi* | [**WithdrawPayouts**](docs/DefaultApi.md#withdrawpayouts) | **POST** /withdrawals | Withdraw payouts


<a id="documentation-for-models"></a>
## Documentation for Models

 - [Model.AccountTokenTupleInner](docs/AccountTokenTupleInner.md)
 - [Model.Action](docs/Action.md)
 - [Model.ActionObject](docs/ActionObject.md)
 - [Model.Add](docs/Add.md)
 - [Model.AddObject](docs/AddObject.md)
 - [Model.AddressAndMetadata](docs/AddressAndMetadata.md)
 - [Model.And](docs/And.md)
 - [Model.AndObject](docs/AndObject.md)
 - [Model.ApplicableInputs](docs/ApplicableInputs.md)
 - [Model.ApplyInputsResponse](docs/ApplyInputsResponse.md)
 - [Model.ApplyInputsResponseLinks](docs/ApplyInputsResponseLinks.md)
 - [Model.ApplyInputsTxEnvelope](docs/ApplyInputsTxEnvelope.md)
 - [Model.Assert](docs/Assert.md)
 - [Model.AssertFail](docs/AssertFail.md)
 - [Model.AssertObject](docs/AssertObject.md)
 - [Model.AssetId](docs/AssetId.md)
 - [Model.Assets](docs/Assets.md)
 - [Model.BlockHeader](docs/BlockHeader.md)
 - [Model.Bound](docs/Bound.md)
 - [Model.CanChoose](docs/CanChoose.md)
 - [Model.CanDeposit](docs/CanDeposit.md)
 - [Model.CanNotify](docs/CanNotify.md)
 - [Model.Case](docs/Case.md)
 - [Model.CaseMerkleizedThen](docs/CaseMerkleizedThen.md)
 - [Model.CaseMerkleizedThenObject](docs/CaseMerkleizedThenObject.md)
 - [Model.CaseObject](docs/CaseObject.md)
 - [Model.CaseThen](docs/CaseThen.md)
 - [Model.CaseThenObject](docs/CaseThenObject.md)
 - [Model.ChoiceAction](docs/ChoiceAction.md)
 - [Model.ChoiceActionObject](docs/ChoiceActionObject.md)
 - [Model.ChoiceContinuationInput](docs/ChoiceContinuationInput.md)
 - [Model.ChoiceId](docs/ChoiceId.md)
 - [Model.ChoiceIdObject](docs/ChoiceIdObject.md)
 - [Model.ChoiceInput](docs/ChoiceInput.md)
 - [Model.ChooseFor](docs/ChooseFor.md)
 - [Model.ChooseForObject](docs/ChooseForObject.md)
 - [Model.Close](docs/Close.md)
 - [Model.CloseObject](docs/CloseObject.md)
 - [Model.ContinuationInput](docs/ContinuationInput.md)
 - [Model.Contract](docs/Contract.md)
 - [Model.ContractHeader](docs/ContractHeader.md)
 - [Model.ContractObject](docs/ContractObject.md)
 - [Model.ContractSourceIds](docs/ContractSourceIds.md)
 - [Model.ContractState](docs/ContractState.md)
 - [Model.CreateContractResponse](docs/CreateContractResponse.md)
 - [Model.CreateContractResponseLinks](docs/CreateContractResponseLinks.md)
 - [Model.CreateTxBodyEnvelope](docs/CreateTxBodyEnvelope.md)
 - [Model.CreateTxEnvelope](docs/CreateTxEnvelope.md)
 - [Model.DepositAction](docs/DepositAction.md)
 - [Model.DepositActionObject](docs/DepositActionObject.md)
 - [Model.DepositContinuationInput](docs/DepositContinuationInput.md)
 - [Model.DepositInput](docs/DepositInput.md)
 - [Model.Divide](docs/Divide.md)
 - [Model.DivideObject](docs/DivideObject.md)
 - [Model.Equal](docs/Equal.md)
 - [Model.EqualObject](docs/EqualObject.md)
 - [Model.ExBudget](docs/ExBudget.md)
 - [Model.GetContractResponse](docs/GetContractResponse.md)
 - [Model.GetContractResponseLinks](docs/GetContractResponseLinks.md)
 - [Model.GetContractsResponse](docs/GetContractsResponse.md)
 - [Model.GetContractsResponseResultsInner](docs/GetContractsResponseResultsInner.md)
 - [Model.GetContractsResponseResultsInnerLinks](docs/GetContractsResponseResultsInnerLinks.md)
 - [Model.GetPayoutResponse](docs/GetPayoutResponse.md)
 - [Model.GetPayoutResponseLinks](docs/GetPayoutResponseLinks.md)
 - [Model.GetPayoutsResponse](docs/GetPayoutsResponse.md)
 - [Model.GetPayoutsResponseResultsInner](docs/GetPayoutsResponseResultsInner.md)
 - [Model.GetPayoutsResponseResultsInnerLinks](docs/GetPayoutsResponseResultsInnerLinks.md)
 - [Model.GetTransactionResponse](docs/GetTransactionResponse.md)
 - [Model.GetTransactionResponseLinks](docs/GetTransactionResponseLinks.md)
 - [Model.GetTransactionsResponse](docs/GetTransactionsResponse.md)
 - [Model.GetTransactionsResponseResultsInner](docs/GetTransactionsResponseResultsInner.md)
 - [Model.GetWithdrawalsResponse](docs/GetWithdrawalsResponse.md)
 - [Model.GetWithdrawalsResponseResultsInner](docs/GetWithdrawalsResponseResultsInner.md)
 - [Model.GetWithdrawalsResponseResultsInnerLinks](docs/GetWithdrawalsResponseResultsInnerLinks.md)
 - [Model.Greater](docs/Greater.md)
 - [Model.GreaterObject](docs/GreaterObject.md)
 - [Model.GreaterOrEqual](docs/GreaterOrEqual.md)
 - [Model.GreaterOrEqualObject](docs/GreaterOrEqualObject.md)
 - [Model.If](docs/If.md)
 - [Model.IfObject](docs/IfObject.md)
 - [Model.IfValue](docs/IfValue.md)
 - [Model.IfValueObject](docs/IfValueObject.md)
 - [Model.Input](docs/Input.md)
 - [Model.IntervalError](docs/IntervalError.md)
 - [Model.IntervalInPast](docs/IntervalInPast.md)
 - [Model.IntervalInPastIntervalInPastError](docs/IntervalInPastIntervalInPastError.md)
 - [Model.InvalidInterval](docs/InvalidInterval.md)
 - [Model.InvalidIntervalInvalidInterval](docs/InvalidIntervalInvalidInterval.md)
 - [Model.LabelRef](docs/LabelRef.md)
 - [Model.LabelledObject](docs/LabelledObject.md)
 - [Model.LabelledObjectValue](docs/LabelledObjectValue.md)
 - [Model.Lesser](docs/Lesser.md)
 - [Model.LesserObject](docs/LesserObject.md)
 - [Model.LesserOrEqual](docs/LesserOrEqual.md)
 - [Model.LesserOrEqualObject](docs/LesserOrEqualObject.md)
 - [Model.Let](docs/Let.md)
 - [Model.LetObject](docs/LetObject.md)
 - [Model.MarloweState](docs/MarloweState.md)
 - [Model.MarloweStateAccountsInnerInner](docs/MarloweStateAccountsInnerInner.md)
 - [Model.MarloweStateBoundValuesInnerInner](docs/MarloweStateBoundValuesInnerInner.md)
 - [Model.MarloweStateChoicesInnerInner](docs/MarloweStateChoicesInnerInner.md)
 - [Model.MarloweVersion](docs/MarloweVersion.md)
 - [Model.Metadata](docs/Metadata.md)
 - [Model.MetadataAndRecipients](docs/MetadataAndRecipients.md)
 - [Model.MetadataAndScript](docs/MetadataAndScript.md)
 - [Model.Minus](docs/Minus.md)
 - [Model.MinusObject](docs/MinusObject.md)
 - [Model.Multiply](docs/Multiply.md)
 - [Model.MultiplyObject](docs/MultiplyObject.md)
 - [Model.Negate](docs/Negate.md)
 - [Model.NegateObject](docs/NegateObject.md)
 - [Model.Next](docs/Next.md)
 - [Model.NonPositiveDeposit](docs/NonPositiveDeposit.md)
 - [Model.NonPositivePayment](docs/NonPositivePayment.md)
 - [Model.Not](docs/Not.md)
 - [Model.NotObject](docs/NotObject.md)
 - [Model.NotifyAction](docs/NotifyAction.md)
 - [Model.NotifyActionObject](docs/NotifyActionObject.md)
 - [Model.NotifyInput](docs/NotifyInput.md)
 - [Model.Observation](docs/Observation.md)
 - [Model.ObservationObject](docs/ObservationObject.md)
 - [Model.Or](docs/Or.md)
 - [Model.OrObject](docs/OrObject.md)
 - [Model.PartialPayment](docs/PartialPayment.md)
 - [Model.Party](docs/Party.md)
 - [Model.PartyAddress](docs/PartyAddress.md)
 - [Model.PartyObject](docs/PartyObject.md)
 - [Model.PartyRoleName](docs/PartyRoleName.md)
 - [Model.Pay](docs/Pay.md)
 - [Model.PayObject](docs/PayObject.md)
 - [Model.PayToAccount](docs/PayToAccount.md)
 - [Model.PayToAccountObject](docs/PayToAccountObject.md)
 - [Model.PayToParty](docs/PayToParty.md)
 - [Model.PayToPartyObject](docs/PayToPartyObject.md)
 - [Model.Payee](docs/Payee.md)
 - [Model.PayeeObject](docs/PayeeObject.md)
 - [Model.Payment](docs/Payment.md)
 - [Model.Payout](docs/Payout.md)
 - [Model.PayoutHeader](docs/PayoutHeader.md)
 - [Model.PayoutState](docs/PayoutState.md)
 - [Model.PayoutStatus](docs/PayoutStatus.md)
 - [Model.PlutusAddress](docs/PlutusAddress.md)
 - [Model.PlutusCredential](docs/PlutusCredential.md)
 - [Model.PlutusStakingCredential](docs/PlutusStakingCredential.md)
 - [Model.PostContractSourceResponse](docs/PostContractSourceResponse.md)
 - [Model.PostContractsRequest](docs/PostContractsRequest.md)
 - [Model.PostContractsRequestContract](docs/PostContractsRequestContract.md)
 - [Model.PostTransactionsRequest](docs/PostTransactionsRequest.md)
 - [Model.PostWithdrawalsRequest](docs/PostWithdrawalsRequest.md)
 - [Model.PubKeyCredential](docs/PubKeyCredential.md)
 - [Model.RoleTokenConfig](docs/RoleTokenConfig.md)
 - [Model.RolesConfig](docs/RolesConfig.md)
 - [Model.SafetyError](docs/SafetyError.md)
 - [Model.ScriptCredential](docs/ScriptCredential.md)
 - [Model.StakingHash](docs/StakingHash.md)
 - [Model.StakingPointer](docs/StakingPointer.md)
 - [Model.TextEnvelope](docs/TextEnvelope.md)
 - [Model.TimeInterval](docs/TimeInterval.md)
 - [Model.Token](docs/Token.md)
 - [Model.TokenInAccount](docs/TokenInAccount.md)
 - [Model.TokenInAccountObject](docs/TokenInAccountObject.md)
 - [Model.TokenMetadata](docs/TokenMetadata.md)
 - [Model.TokenMetadataFile](docs/TokenMetadataFile.md)
 - [Model.TokenObject](docs/TokenObject.md)
 - [Model.Transaction](docs/Transaction.md)
 - [Model.TransactionError](docs/TransactionError.md)
 - [Model.TransactionErrorOneOf](docs/TransactionErrorOneOf.md)
 - [Model.TransactionInput](docs/TransactionInput.md)
 - [Model.TransactionInputTxInterval](docs/TransactionInputTxInterval.md)
 - [Model.TransactionOutput](docs/TransactionOutput.md)
 - [Model.TransactionWarning](docs/TransactionWarning.md)
 - [Model.Tx](docs/Tx.md)
 - [Model.TxHeader](docs/TxHeader.md)
 - [Model.TxOutputError](docs/TxOutputError.md)
 - [Model.TxOutputSuccess](docs/TxOutputSuccess.md)
 - [Model.TxStatus](docs/TxStatus.md)
 - [Model.UseValue](docs/UseValue.md)
 - [Model.Value](docs/Value.md)
 - [Model.ValueObject](docs/ValueObject.md)
 - [Model.ValueOfChoice](docs/ValueOfChoice.md)
 - [Model.ValueOfChoiceObject](docs/ValueOfChoiceObject.md)
 - [Model.VariableShadowing](docs/VariableShadowing.md)
 - [Model.When](docs/When.md)
 - [Model.WhenObject](docs/WhenObject.md)
 - [Model.WithdrawPayoutsResponse](docs/WithdrawPayoutsResponse.md)
 - [Model.WithdrawTxBodyEnvelope](docs/WithdrawTxBodyEnvelope.md)
 - [Model.WithdrawTxEnvelope](docs/WithdrawTxEnvelope.md)
 - [Model.Withdrawal](docs/Withdrawal.md)
 - [Model.WithdrawalHeader](docs/WithdrawalHeader.md)


<a id="documentation-for-authorization"></a>
## Documentation for Authorization

Endpoints do not require authorization.

