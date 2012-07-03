using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class DoubleCollection : IVector<double>, IIterable<double>
	{
		public extern uint Size
		{
			get;
		}
		public extern DoubleCollection();
		public extern double GetAt([In] uint index);
		public extern IVectorView<double> GetView();
		public extern bool IndexOf([In] double value, out uint index);
		public extern void SetAt([In] uint index, [In] double value);
		public extern void InsertAt([In] uint index, [In] double value);
		public extern void RemoveAt([In] uint index);
		public extern void Append([In] double value);
		public extern void RemoveAtEnd();
		public extern void Clear();
		public extern uint GetMany([In] uint startIndex, [Out] double[] items);
		public extern void ReplaceAll([In] double[] items);
		public extern IIterator<double> First();
	}
}
