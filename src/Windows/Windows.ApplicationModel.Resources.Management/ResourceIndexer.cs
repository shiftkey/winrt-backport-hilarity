using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Resources.Management
{
	[Activatable(typeof(IResourceIndexerFactory), 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class ResourceIndexer : IResourceIndexer
	{
		public extern ResourceIndexer([In] Uri projectRoot);
		public extern IndexedResourceCandidate IndexFilePath([In] Uri filePath);
		public extern IAsyncOperation<IVectorView<IndexedResourceCandidate>> IndexFileContentsAsync([In] Uri file);
	}
}
