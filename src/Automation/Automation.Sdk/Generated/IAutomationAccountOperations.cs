// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Automation
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// AutomationAccountOperations operations.
    /// </summary>
    public partial interface IAutomationAccountOperations
    {
        /// <summary>
        /// Update an automation account.
        /// </summary>
        /// <remarks>
        /// Update an automation account.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of an Azure Resource group.
        /// </param>
        /// <param name='automationAccountName'>
        /// The name of the automation account.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the update automation account.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<AutomationAccount>> UpdateWithHttpMessagesAsync(string resourceGroupName, string automationAccountName, AutomationAccountUpdateParameters parameters, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Create or update automation account.
        /// </summary>
        /// <remarks>
        /// Create or update automation account.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of an Azure Resource group.
        /// </param>
        /// <param name='automationAccountName'>
        /// The name of the automation account.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the create or update automation account.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<AutomationAccount>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string automationAccountName, AutomationAccountCreateOrUpdateParameters parameters, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Delete an automation account.
        /// </summary>
        /// <remarks>
        /// Delete an automation account.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of an Azure Resource group.
        /// </param>
        /// <param name='automationAccountName'>
        /// The name of the automation account.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string automationAccountName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get information about an Automation Account.
        /// </summary>
        /// <remarks>
        /// Get information about an Automation Account.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of an Azure Resource group.
        /// </param>
        /// <param name='automationAccountName'>
        /// The name of the automation account.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<AutomationAccount>> GetWithHttpMessagesAsync(string resourceGroupName, string automationAccountName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Retrieve a list of accounts within a given resource group.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of accounts within a given resource group.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Name of an Azure Resource group.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<AutomationAccount>>> ListByResourceGroupWithHttpMessagesAsync(string resourceGroupName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Retrieve a list of accounts within a given subscription.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of accounts within a given subscription.
        /// </remarks>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<AutomationAccount>>> ListWithHttpMessagesAsync(System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Retrieve a list of accounts within a given resource group.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of accounts within a given resource group.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<AutomationAccount>>> ListByResourceGroupNextWithHttpMessagesAsync(string nextPageLink, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Retrieve a list of accounts within a given subscription.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of accounts within a given subscription.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<AutomationAccount>>> ListNextWithHttpMessagesAsync(string nextPageLink, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

    }
}