using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Data
{
	[Guid(2136926610u, 30356, 20076, 165, 27, 227, 75, 244, 61, 231, 67), Version(100794368u), WebHostHidden]
	public interface ISupportIncrementalLoading
	{
		bool HasMoreItems
		{
			get;
		}
		IAsyncOperation<LoadMoreItemsResult> LoadMoreItemsAsync([In] uint count);
	}
}
