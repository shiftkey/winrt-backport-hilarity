using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Pickers
{
	[Version(100794368u)]
	public sealed class FilePickerFileTypesOrderedMap : IMap<string, IVector<string>>, IIterable<IKeyValuePair<string, IVector<string>>>
	{
		public extern uint Size
		{
			get;
		}
		public extern IVector<string> Lookup([In] string key);
		public extern bool HasKey([In] string key);
		public extern IMapView<string, IVector<string>> GetView();
		public extern bool Insert([In] string key, [In] IVector<string> value);
		public extern void Remove([In] string key);
		public extern void Clear();
		public extern IIterator<IKeyValuePair<string, IVector<string>>> First();
	}
}
