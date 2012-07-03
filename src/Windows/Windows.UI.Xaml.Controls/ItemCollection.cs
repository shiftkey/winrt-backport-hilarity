using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class ItemCollection : IObservableVector<object>, IVector<object>, IIterable<object>
	{
		public extern event VectorChangedEventHandler<object> VectorChanged
		{
			add;
			remove;
		}
		public extern uint Size
		{
			get;
		}
		public extern object GetAt([In] uint index);
		public extern IVectorView<object> GetView();
		public extern bool IndexOf([In] object value, out uint index);
		public extern void SetAt([In] uint index, [In] object value);
		public extern void InsertAt([In] uint index, [In] object value);
		public extern void RemoveAt([In] uint index);
		public extern void Append([In] object value);
		public extern void RemoveAtEnd();
		public extern void Clear();
		public extern uint GetMany([In] uint startIndex, [Out] object[] items);
		public extern void ReplaceAll([In] object[] items);
		public extern IIterator<object> First();
	}
}
