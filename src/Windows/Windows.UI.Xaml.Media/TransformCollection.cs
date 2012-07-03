using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class TransformCollection : IVector<Transform>, IIterable<Transform>
	{
		public extern uint Size
		{
			get;
		}
		public extern TransformCollection();
		public extern Transform GetAt([In] uint index);
		public extern IVectorView<Transform> GetView();
		public extern bool IndexOf([In] Transform value, out uint index);
		public extern void SetAt([In] uint index, [In] Transform value);
		public extern void InsertAt([In] uint index, [In] Transform value);
		public extern void RemoveAt([In] uint index);
		public extern void Append([In] Transform value);
		public extern void RemoveAtEnd();
		public extern void Clear();
		public extern uint GetMany([In] uint startIndex, [Out] Transform[] items);
		public extern void ReplaceAll([In] Transform[] items);
		public extern IIterator<Transform> First();
	}
}
