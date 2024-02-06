# MarloweAPIClient.Model.ContractState

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Assets** | [**Assets**](Assets.md) |  | 
**Block** | [**BlockHeader**](BlockHeader.md) |  | [optional] 
**Continuations** | **string** |  | [optional] 
**ContractId** | **string** | A reference to a transaction output with a transaction ID and index. | 
**CurrentContract** | [**Contract**](Contract.md) |  | [optional] 
**InitialContract** | [**Contract**](Contract.md) |  | 
**Metadata** | [**Dictionary&lt;string, Metadata&gt;**](Metadata.md) |  | 
**RoleTokenMintingPolicyId** | **string** | The hex-encoded minting policy ID for a native Cardano token | 
**State** | [**MarloweState**](MarloweState.md) |  | [optional] 
**Status** | **TxStatus** |  | 
**Tags** | [**Dictionary&lt;string, Metadata&gt;**](Metadata.md) |  | 
**TxBody** | [**TextEnvelope**](TextEnvelope.md) |  | [optional] 
**UnclaimedPayouts** | [**List&lt;Payout&gt;**](Payout.md) |  | 
**Utxo** | **string** | A reference to a transaction output with a transaction ID and index. | [optional] 
**VarVersion** | **MarloweVersion** |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

