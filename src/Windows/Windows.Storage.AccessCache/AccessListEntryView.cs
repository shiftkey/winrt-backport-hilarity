using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Storage.AccessCache
{
	[Version(100794368u)]
	public sealed class AccessListEntryView : IVectorView<AccessListEntry>, IIterable<AccessListEntry>
	{
		public extern uint Size
		{
			get;
		}
		public extern AccessListEntry GetAt([In] uint index);
		public extern bool IndexOf([In] AccessListEntry value, out uint index);
		public extern uint GetMany([In] uint startIndex, [Out] AccessListEntry[] items);
		public extern IIterator<AccessListEntry> First();
	}
}
