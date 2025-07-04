// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.CognitiveServices
{
    /// <summary>
    /// A class representing a collection of <see cref="CognitiveServicesDeletedAccountResource"/> and their operations.
    /// Each <see cref="CognitiveServicesDeletedAccountResource"/> in the collection will belong to the same instance of <see cref="SubscriptionResource"/>.
    /// To get a <see cref="CognitiveServicesDeletedAccountCollection"/> instance call the GetCognitiveServicesDeletedAccounts method from an instance of <see cref="SubscriptionResource"/>.
    /// </summary>
    public partial class CognitiveServicesDeletedAccountCollection : ArmCollection
    {
        private readonly ClientDiagnostics _cognitiveServicesDeletedAccountDeletedAccountsClientDiagnostics;
        private readonly DeletedAccountsRestOperations _cognitiveServicesDeletedAccountDeletedAccountsRestClient;

        /// <summary> Initializes a new instance of the <see cref="CognitiveServicesDeletedAccountCollection"/> class for mocking. </summary>
        protected CognitiveServicesDeletedAccountCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CognitiveServicesDeletedAccountCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CognitiveServicesDeletedAccountCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _cognitiveServicesDeletedAccountDeletedAccountsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CognitiveServices", CognitiveServicesDeletedAccountResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CognitiveServicesDeletedAccountResource.ResourceType, out string cognitiveServicesDeletedAccountDeletedAccountsApiVersion);
            _cognitiveServicesDeletedAccountDeletedAccountsRestClient = new DeletedAccountsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cognitiveServicesDeletedAccountDeletedAccountsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Returns a Cognitive Services account specified by the parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.CognitiveServices/locations/{location}/resourceGroups/{resourceGroupName}/deletedAccounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeletedAccounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CognitiveServicesDeletedAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> Resource location. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="accountName"> The name of Cognitive Services account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceGroupName"/> or <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="accountName"/> is null. </exception>
        public virtual async Task<Response<CognitiveServicesDeletedAccountResource>> GetAsync(AzureLocation location, string resourceGroupName, string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var scope = _cognitiveServicesDeletedAccountDeletedAccountsClientDiagnostics.CreateScope("CognitiveServicesDeletedAccountCollection.Get");
            scope.Start();
            try
            {
                var response = await _cognitiveServicesDeletedAccountDeletedAccountsRestClient.GetAsync(Id.SubscriptionId, location, resourceGroupName, accountName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CognitiveServicesDeletedAccountResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a Cognitive Services account specified by the parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.CognitiveServices/locations/{location}/resourceGroups/{resourceGroupName}/deletedAccounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeletedAccounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CognitiveServicesDeletedAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> Resource location. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="accountName"> The name of Cognitive Services account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceGroupName"/> or <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="accountName"/> is null. </exception>
        public virtual Response<CognitiveServicesDeletedAccountResource> Get(AzureLocation location, string resourceGroupName, string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var scope = _cognitiveServicesDeletedAccountDeletedAccountsClientDiagnostics.CreateScope("CognitiveServicesDeletedAccountCollection.Get");
            scope.Start();
            try
            {
                var response = _cognitiveServicesDeletedAccountDeletedAccountsRestClient.Get(Id.SubscriptionId, location, resourceGroupName, accountName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CognitiveServicesDeletedAccountResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.CognitiveServices/locations/{location}/resourceGroups/{resourceGroupName}/deletedAccounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeletedAccounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CognitiveServicesDeletedAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> Resource location. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="accountName"> The name of Cognitive Services account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceGroupName"/> or <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="accountName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(AzureLocation location, string resourceGroupName, string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var scope = _cognitiveServicesDeletedAccountDeletedAccountsClientDiagnostics.CreateScope("CognitiveServicesDeletedAccountCollection.Exists");
            scope.Start();
            try
            {
                var response = await _cognitiveServicesDeletedAccountDeletedAccountsRestClient.GetAsync(Id.SubscriptionId, location, resourceGroupName, accountName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.CognitiveServices/locations/{location}/resourceGroups/{resourceGroupName}/deletedAccounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeletedAccounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CognitiveServicesDeletedAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> Resource location. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="accountName"> The name of Cognitive Services account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceGroupName"/> or <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="accountName"/> is null. </exception>
        public virtual Response<bool> Exists(AzureLocation location, string resourceGroupName, string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var scope = _cognitiveServicesDeletedAccountDeletedAccountsClientDiagnostics.CreateScope("CognitiveServicesDeletedAccountCollection.Exists");
            scope.Start();
            try
            {
                var response = _cognitiveServicesDeletedAccountDeletedAccountsRestClient.Get(Id.SubscriptionId, location, resourceGroupName, accountName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.CognitiveServices/locations/{location}/resourceGroups/{resourceGroupName}/deletedAccounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeletedAccounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CognitiveServicesDeletedAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> Resource location. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="accountName"> The name of Cognitive Services account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceGroupName"/> or <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="accountName"/> is null. </exception>
        public virtual async Task<NullableResponse<CognitiveServicesDeletedAccountResource>> GetIfExistsAsync(AzureLocation location, string resourceGroupName, string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var scope = _cognitiveServicesDeletedAccountDeletedAccountsClientDiagnostics.CreateScope("CognitiveServicesDeletedAccountCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _cognitiveServicesDeletedAccountDeletedAccountsRestClient.GetAsync(Id.SubscriptionId, location, resourceGroupName, accountName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<CognitiveServicesDeletedAccountResource>(response.GetRawResponse());
                return Response.FromValue(new CognitiveServicesDeletedAccountResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.CognitiveServices/locations/{location}/resourceGroups/{resourceGroupName}/deletedAccounts/{accountName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeletedAccounts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CognitiveServicesDeletedAccountResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> Resource location. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="accountName"> The name of Cognitive Services account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceGroupName"/> or <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="accountName"/> is null. </exception>
        public virtual NullableResponse<CognitiveServicesDeletedAccountResource> GetIfExists(AzureLocation location, string resourceGroupName, string accountName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(accountName, nameof(accountName));

            using var scope = _cognitiveServicesDeletedAccountDeletedAccountsClientDiagnostics.CreateScope("CognitiveServicesDeletedAccountCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _cognitiveServicesDeletedAccountDeletedAccountsRestClient.Get(Id.SubscriptionId, location, resourceGroupName, accountName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<CognitiveServicesDeletedAccountResource>(response.GetRawResponse());
                return Response.FromValue(new CognitiveServicesDeletedAccountResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
