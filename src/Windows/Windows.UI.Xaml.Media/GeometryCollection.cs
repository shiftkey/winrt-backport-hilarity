using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class GeometryCollection : IVector<Geometry>, IIterable<Geometry>
	{
		public extern uint Size
		{
			get;
		}
		public extern GeometryCollection();
		public extern Geometry GetAt([In] uint index);
		public extern IVectorView<Geometry> GetView();
		public extern bool IndexOf([In] Geometry value, out uint index);
		public extern void SetAt([In] uint index, [In] Geometry value);
		public extern void InsertAt([In] uint index, [In] Geometry value);
		public extern void RemoveAt([In] uint index);
		public extern void Append([In] Geometry value);
		public extern void RemoveAtEnd();
		public extern void Clear();
		public extern uint GetMany([In] uint startIndex, [Out] Geometry[] items);
		public extern void ReplaceAll([In] Geometry[] items);
		public extern IIterator<Geometry> First();
	}
}
