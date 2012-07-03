using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.Storage.Streams;
namespace Windows.ApplicationModel.DataTransfer
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class DataPackageView : IDataPackageView
	{
		public extern IVectorView<string> AvailableFormats
		{
			get;
		}
		public extern DataPackagePropertySetView Properties
		{
			get;
		}
		public extern DataPackageOperation RequestedOperation
		{
			get;
		}
		public extern void ReportOperationCompleted([In] DataPackageOperation value);
		public extern bool Contains([In] string formatId);
		[return: HasVariant]
		public extern IAsyncOperation<object> GetDataAsync([In] string formatId);
		[Overload("GetTextAsync")]
		public extern IAsyncOperation<string> GetTextAsync();
		[Overload("GetCustomTextAsync")]
		public extern IAsyncOperation<string> GetTextAsync([In] string formatId);
		public extern IAsyncOperation<Uri> GetUriAsync();
		public extern IAsyncOperation<string> GetHtmlFormatAsync();
		public extern IAsyncOperation<IMapView<string, RandomAccessStreamReference>> GetResourceMapAsync();
		public extern IAsyncOperation<string> GetRtfAsync();
		public extern IAsyncOperation<RandomAccessStreamReference> GetBitmapAsync();
		public extern IAsyncOperation<IVectorView<IStorageItem>> GetStorageItemsAsync();
	}
}
