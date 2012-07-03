using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.Web.Syndication;
namespace Windows.Web.AtomPub
{
	[ExclusiveTo(typeof(AtomPubClient)), Guid(892939320u, 52717, 19788, 150, 55, 5, 241, 92, 28, 148, 6), Version(100794368u)]
	internal interface IAtomPubClient : ISyndicationClient
	{
		IAsyncOperationWithProgress<ServiceDocument, RetrievalProgress> RetrieveServiceDocumentAsync([In] Uri uri);
		IAsyncOperationWithProgress<IInputStream, RetrievalProgress> RetrieveMediaResourceAsync([In] Uri uri);
		IAsyncOperationWithProgress<SyndicationItem, RetrievalProgress> RetrieveResourceAsync([In] Uri uri);
		IAsyncOperationWithProgress<SyndicationItem, TransferProgress> CreateResourceAsync([In] Uri uri, [In] string description, [In] SyndicationItem item);
		IAsyncOperationWithProgress<SyndicationItem, TransferProgress> CreateMediaResourceAsync([In] Uri uri, [In] string mediaType, [In] string description, [In] IInputStream mediaStream);
		IAsyncActionWithProgress<TransferProgress> UpdateMediaResourceAsync([In] Uri uri, [In] string mediaType, [In] IInputStream mediaStream);
		IAsyncActionWithProgress<TransferProgress> UpdateResourceAsync([In] Uri uri, [In] SyndicationItem item);
		IAsyncActionWithProgress<TransferProgress> UpdateResourceItemAsync([In] SyndicationItem item);
		IAsyncActionWithProgress<TransferProgress> DeleteResourceAsync([In] Uri uri);
		IAsyncActionWithProgress<TransferProgress> DeleteResourceItemAsync([In] SyndicationItem item);
		void CancelAsyncOperations();
	}
}
