using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Documents
{
	[MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class BlockCollection : IVector<Block>, IIterable<Block>
	{
		public extern uint Size
		{
			get;
		}
		public extern Block GetAt([In] uint index);
		public extern IVectorView<Block> GetView();
		public extern bool IndexOf([In] Block value, out uint index);
		public extern void SetAt([In] uint index, [In] Block value);
		public extern void InsertAt([In] uint index, [In] Block value);
		public extern void RemoveAt([In] uint index);
		public extern void Append([In] Block value);
		public extern void RemoveAtEnd();
		public extern void Clear();
		public extern uint GetMany([In] uint startIndex, [Out] Block[] items);
		public extern void ReplaceAll([In] Block[] items);
		public extern IIterator<Block> First();
	}
}
