using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.Storage.Streams;
namespace Windows.ApplicationModel.DataTransfer
{
	[ExclusiveTo(typeof(DataPackageView)), Guid(2072249457u, 22784, 19845, 169, 11, 16, 203, 133, 254, 53, 82), Version(100794368u)]
	internal interface IDataPackageView
	{
		IVectorView<string> AvailableFormats
		{
			get;
		}
		DataPackagePropertySetView Properties
		{
			get;
		}
		DataPackageOperation RequestedOperation
		{
			get;
		}
		void ReportOperationCompleted([In] DataPackageOperation value);
		bool Contains([In] string formatId);
		[return: HasVariant]
		IAsyncOperation<object> GetDataAsync([In] string formatId);
		[Overload("GetTextAsync")]
		IAsyncOperation<string> GetTextAsync();
		[Overload("GetCustomTextAsync")]
		IAsyncOperation<string> GetTextAsync([In] string formatId);
		IAsyncOperation<Uri> GetUriAsync();
		IAsyncOperation<string> GetHtmlFormatAsync();
		IAsyncOperation<IMapView<string, RandomAccessStreamReference>> GetResourceMapAsync();
		IAsyncOperation<string> GetRtfAsync();
		IAsyncOperation<RandomAccessStreamReference> GetBitmapAsync();
		IAsyncOperation<IVectorView<IStorageItem>> GetStorageItemsAsync();
	}
}
