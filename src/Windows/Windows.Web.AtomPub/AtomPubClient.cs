using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;
using Windows.Storage.Streams;
using Windows.Web.Syndication;
namespace Windows.Web.AtomPub
{
	[Activatable(100794368u), Activatable(typeof(IAtomPubClientFactory), 100794368u), DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class AtomPubClient : IAtomPubClient, ISyndicationClient
	{
		public extern bool BypassCacheOnRetrieve
		{
			get;
			set;
		}
		public extern uint MaxResponseBufferSize
		{
			get;
			set;
		}
		public extern PasswordCredential ProxyCredential
		{
			get;
			set;
		}
		public extern PasswordCredential ServerCredential
		{
			get;
			set;
		}
		public extern uint Timeout
		{
			get;
			set;
		}
		public extern AtomPubClient([In] PasswordCredential serverCredential);
		public extern AtomPubClient();
		public extern IAsyncOperationWithProgress<ServiceDocument, RetrievalProgress> RetrieveServiceDocumentAsync([In] Uri uri);
		public extern IAsyncOperationWithProgress<IInputStream, RetrievalProgress> RetrieveMediaResourceAsync([In] Uri uri);
		public extern IAsyncOperationWithProgress<SyndicationItem, RetrievalProgress> RetrieveResourceAsync([In] Uri uri);
		public extern IAsyncOperationWithProgress<SyndicationItem, TransferProgress> CreateResourceAsync([In] Uri uri, [In] string description, [In] SyndicationItem item);
		public extern IAsyncOperationWithProgress<SyndicationItem, TransferProgress> CreateMediaResourceAsync([In] Uri uri, [In] string mediaType, [In] string description, [In] IInputStream mediaStream);
		public extern IAsyncActionWithProgress<TransferProgress> UpdateMediaResourceAsync([In] Uri uri, [In] string mediaType, [In] IInputStream mediaStream);
		public extern IAsyncActionWithProgress<TransferProgress> UpdateResourceAsync([In] Uri uri, [In] SyndicationItem item);
		public extern IAsyncActionWithProgress<TransferProgress> UpdateResourceItemAsync([In] SyndicationItem item);
		public extern IAsyncActionWithProgress<TransferProgress> DeleteResourceAsync([In] Uri uri);
		public extern IAsyncActionWithProgress<TransferProgress> DeleteResourceItemAsync([In] SyndicationItem item);
		public extern void CancelAsyncOperations();
		public extern void SetRequestHeader([In] string name, [In] string value);
		public extern IAsyncOperationWithProgress<SyndicationFeed, RetrievalProgress> RetrieveFeedAsync([In] Uri uri);
	}
}
