using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Imaging
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class BitmapPropertySet : IMap<string, BitmapTypedValue>, IIterable<IKeyValuePair<string, BitmapTypedValue>>
	{
		public extern uint Size
		{
			get;
		}
		public extern BitmapPropertySet();
		public extern BitmapTypedValue Lookup([In] string key);
		public extern bool HasKey([In] string key);
		public extern IMapView<string, BitmapTypedValue> GetView();
		public extern bool Insert([In] string key, [In] BitmapTypedValue value);
		public extern void Remove([In] string key);
		public extern void Clear();
		public extern IIterator<IKeyValuePair<string, BitmapTypedValue>> First();
	}
}
