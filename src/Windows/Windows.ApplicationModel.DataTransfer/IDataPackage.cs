using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.Storage.Streams;
namespace Windows.ApplicationModel.DataTransfer
{
	[ExclusiveTo(typeof(DataPackage)), Guid(1642853831u, 61418, 17222, 149, 84, 152, 29, 126, 25, 143, 254), Version(100794368u)]
	internal interface IDataPackage
	{
		event TypedEventHandler<DataPackage, object> Destroyed;
		event TypedEventHandler<DataPackage, OperationCompletedEventArgs> OperationCompleted;
		DataPackagePropertySet Properties
		{
			get;
		}
		DataPackageOperation RequestedOperation
		{
			get;
			set;
		}
		IMap<string, RandomAccessStreamReference> ResourceMap
		{
			get;
		}
		DataPackageView GetView();
		void SetData([In] string formatId, [HasVariant] [In] object value);
		void SetDataProvider([In] string formatId, [In] DataProviderHandler delayRenderer);
		void SetText([In] string value);
		void SetUri([In] Uri value);
		void SetHtmlFormat([In] string value);
		void SetRtf([In] string value);
		void SetBitmap([In] RandomAccessStreamReference value);
		[Overload("SetStorageItemsReadOnly")]
		void SetStorageItems([In] IIterable<IStorageItem> value);
		[Overload("SetStorageItems")]
		void SetStorageItems([In] IIterable<IStorageItem> value, [In] bool readOnly);
	}
}
