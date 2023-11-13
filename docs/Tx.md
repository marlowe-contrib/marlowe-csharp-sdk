# MarloweAPIClient.Model.Tx

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Assets** | [**Assets**](Assets.md) |  | 
**Block** | [**BlockHeader**](BlockHeader.md) |  | [optional] 
**ConsumingTx** | **string** | The hex-encoded identifier of a Cardano transaction | [optional] 
**Continuations** | **string** |  | [optional] 
**ContractId** | **string** | A reference to a transaction output with a transaction ID and index. | 
**InputUtxo** | **string** | A reference to a transaction output with a transaction ID and index. | 
**Inputs** | [**List&lt;Input&gt;**](Input.md) |  | 
**InvalidBefore** | **string** |  | 
**InvalidHereafter** | **string** |  | 
**Metadata** | **Dictionary&lt;string, Object&gt;** |  | 
**OutputContract** | [**Contract**](Contract.md) |  | [optional] 
**OutputState** | [**MarloweState**](MarloweState.md) |  | [optional] 
**OutputUtxo** | **string** | A reference to a transaction output with a transaction ID and index. | [optional] 
**Payouts** | [**List&lt;Payout&gt;**](Payout.md) |  | 
**Status** | **TxStatus** |  | 
**Tags** | **Dictionary&lt;string, Object&gt;** |  | 
**TransactionId** | **string** | The hex-encoded identifier of a Cardano transaction | 
**TxBody** | [**TextEnvelope**](TextEnvelope.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

