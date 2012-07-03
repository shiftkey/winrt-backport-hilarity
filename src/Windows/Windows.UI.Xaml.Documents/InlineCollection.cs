using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Documents
{
	[MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class InlineCollection : IVector<Inline>, IIterable<Inline>
	{
		public extern uint Size
		{
			get;
		}
		public extern Inline GetAt([In] uint index);
		public extern IVectorView<Inline> GetView();
		public extern bool IndexOf([In] Inline value, out uint index);
		public extern void SetAt([In] uint index, [In] Inline value);
		public extern void InsertAt([In] uint index, [In] Inline value);
		public extern void RemoveAt([In] uint index);
		public extern void Append([In] Inline value);
		public extern void RemoveAtEnd();
		public extern void Clear();
		public extern uint GetMany([In] uint startIndex, [Out] Inline[] items);
		public extern void ReplaceAll([In] Inline[] items);
		public extern IIterator<Inline> First();
	}
}
