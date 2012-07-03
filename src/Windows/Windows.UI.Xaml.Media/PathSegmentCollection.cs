using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class PathSegmentCollection : IVector<PathSegment>, IIterable<PathSegment>
	{
		public extern uint Size
		{
			get;
		}
		public extern PathSegmentCollection();
		public extern PathSegment GetAt([In] uint index);
		public extern IVectorView<PathSegment> GetView();
		public extern bool IndexOf([In] PathSegment value, out uint index);
		public extern void SetAt([In] uint index, [In] PathSegment value);
		public extern void InsertAt([In] uint index, [In] PathSegment value);
		public extern void RemoveAt([In] uint index);
		public extern void Append([In] PathSegment value);
		public extern void RemoveAtEnd();
		public extern void Clear();
		public extern uint GetMany([In] uint startIndex, [Out] PathSegment[] items);
		public extern void ReplaceAll([In] PathSegment[] items);
		public extern IIterator<PathSegment> First();
	}
}
