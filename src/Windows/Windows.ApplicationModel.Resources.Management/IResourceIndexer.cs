using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Resources.Management
{
	[ExclusiveTo(typeof(ResourceIndexer)), Guid(760019365u, 58159, 19122, 135, 72, 150, 53, 10, 1, 109, 163), Version(100794368u), WebHostHidden]
	internal interface IResourceIndexer
	{
		IndexedResourceCandidate IndexFilePath([In] Uri filePath);
		IAsyncOperation<IVectorView<IndexedResourceCandidate>> IndexFileContentsAsync([In] Uri file);
	}
}
