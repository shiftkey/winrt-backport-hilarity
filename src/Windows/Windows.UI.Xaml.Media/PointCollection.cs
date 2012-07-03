using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class PointCollection : IVector<Point>, IIterable<Point>
	{
		public extern uint Size
		{
			get;
		}
		public extern PointCollection();
		public extern Point GetAt([In] uint index);
		public extern IVectorView<Point> GetView();
		public extern bool IndexOf([In] Point value, out uint index);
		public extern void SetAt([In] uint index, [In] Point value);
		public extern void InsertAt([In] uint index, [In] Point value);
		public extern void RemoveAt([In] uint index);
		public extern void Append([In] Point value);
		public extern void RemoveAtEnd();
		public extern void Clear();
		public extern uint GetMany([In] uint startIndex, [Out] Point[] items);
		public extern void ReplaceAll([In] Point[] items);
		public extern IIterator<Point> First();
	}
}
