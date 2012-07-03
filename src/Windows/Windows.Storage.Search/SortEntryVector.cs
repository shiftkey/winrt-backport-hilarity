using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Search
{
	[Version(100794368u)]
	public sealed class SortEntryVector : IVector<SortEntry>, IIterable<SortEntry>
	{
		public extern uint Size
		{
			get;
		}
		public extern SortEntry GetAt([In] uint index);
		public extern IVectorView<SortEntry> GetView();
		public extern bool IndexOf([In] SortEntry value, out uint index);
		public extern void SetAt([In] uint index, [In] SortEntry value);
		public extern void InsertAt([In] uint index, [In] SortEntry value);
		public extern void RemoveAt([In] uint index);
		public extern void Append([In] SortEntry value);
		public extern void RemoveAtEnd();
		public extern void Clear();
		public extern uint GetMany([In] uint startIndex, [Out] SortEntry[] items);
		public extern void ReplaceAll([In] SortEntry[] items);
		public extern IIterator<SortEntry> First();
	}
}
