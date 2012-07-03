using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
namespace Windows.ApplicationModel.DataTransfer
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class DataPackagePropertySet : IDataPackagePropertySet, IMap<string, object>, IIterable<IKeyValuePair<string, object>>
	{
		public extern Uri ApplicationListingUri
		{
			get;
			set;
		}
		public extern string ApplicationName
		{
			get;
			set;
		}
		public extern string Description
		{
			get;
			set;
		}
		public extern IVector<string> FileTypes
		{
			get;
		}
		public extern IRandomAccessStreamReference Thumbnail
		{
			get;
			set;
		}
		public extern string Title
		{
			get;
			set;
		}
		public extern uint Size
		{
			get;
		}
		public extern object Lookup([In] string key);
		public extern bool HasKey([In] string key);
		public extern IMapView<string, object> GetView();
		public extern bool Insert([In] string key, [In] object value);
		public extern void Remove([In] string key);
		public extern void Clear();
		public extern IIterator<IKeyValuePair<string, object>> First();
	}
}
