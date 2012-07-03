using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class GradientStopCollection : IVector<GradientStop>, IIterable<GradientStop>
	{
		public extern uint Size
		{
			get;
		}
		public extern GradientStopCollection();
		public extern GradientStop GetAt([In] uint index);
		public extern IVectorView<GradientStop> GetView();
		public extern bool IndexOf([In] GradientStop value, out uint index);
		public extern void SetAt([In] uint index, [In] GradientStop value);
		public extern void InsertAt([In] uint index, [In] GradientStop value);
		public extern void RemoveAt([In] uint index);
		public extern void Append([In] GradientStop value);
		public extern void RemoveAtEnd();
		public extern void Clear();
		public extern uint GetMany([In] uint startIndex, [Out] GradientStop[] items);
		public extern void ReplaceAll([In] GradientStop[] items);
		public extern IIterator<GradientStop> First();
	}
}
