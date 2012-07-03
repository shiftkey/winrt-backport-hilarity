using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage;
using Windows.Storage.Streams;
namespace Windows.ApplicationModel.DataTransfer
{
	[Activatable(100794368u), DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class DataPackage : IDataPackage
	{
		public extern event TypedEventHandler<DataPackage, object> Destroyed
		{
			add;
			remove;
		}
		public extern event TypedEventHandler<DataPackage, OperationCompletedEventArgs> OperationCompleted
		{
			add;
			remove;
		}
		public extern DataPackagePropertySet Properties
		{
			get;
		}
		public extern DataPackageOperation RequestedOperation
		{
			get;
			set;
		}
		public extern IMap<string, RandomAccessStreamReference> ResourceMap
		{
			get;
		}
		public extern DataPackage();
		public extern DataPackageView GetView();
		public extern void SetData([In] string formatId, [HasVariant] [In] object value);
		public extern void SetDataProvider([In] string formatId, [In] DataProviderHandler delayRenderer);
		public extern void SetText([In] string value);
		public extern void SetUri([In] Uri value);
		public extern void SetHtmlFormat([In] string value);
		public extern void SetRtf([In] string value);
		public extern void SetBitmap([In] RandomAccessStreamReference value);
		[Overload("SetStorageItemsReadOnly")]
		public extern void SetStorageItems([In] IIterable<IStorageItem> value);
		[Overload("SetStorageItems")]
		public extern void SetStorageItems([In] IIterable<IStorageItem> value, [In] bool readOnly);
	}
}
