using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.ApplicationModel.DataTransfer
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class DataPackagePropertySetView : IDataPackagePropertySetView, IMapView<string, object>, IIterable<IKeyValuePair<string, object>>
	{
		public extern Uri ApplicationListingUri
		{
			get;
		}
		public extern string ApplicationName
		{
			get;
		}
		public extern string Description
		{
			get;
		}
		public extern IVectorView<string> FileTypes
		{
			get;
		}
		public extern RandomAccessStreamReference Thumbnail
		{
			get;
		}
		public extern string Title
		{
			get;
		}
		public extern uint Size
		{
			get;
		}
		public extern object Lookup([In] string key);
		public extern bool HasKey([In] string key);
		public extern void Split(out IMapView<string, object> first, out IMapView<string, object> second);
		public extern IIterator<IKeyValuePair<string, object>> First();
	}
}
