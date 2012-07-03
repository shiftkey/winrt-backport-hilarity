using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class UIElementCollection : IVector<UIElement>, IIterable<UIElement>
	{
		public extern uint Size
		{
			get;
		}
		public extern UIElement GetAt([In] uint index);
		public extern IVectorView<UIElement> GetView();
		public extern bool IndexOf([In] UIElement value, out uint index);
		public extern void SetAt([In] uint index, [In] UIElement value);
		public extern void InsertAt([In] uint index, [In] UIElement value);
		public extern void RemoveAt([In] uint index);
		public extern void Append([In] UIElement value);
		public extern void RemoveAtEnd();
		public extern void Clear();
		public extern uint GetMany([In] uint startIndex, [Out] UIElement[] items);
		public extern void ReplaceAll([In] UIElement[] items);
		public extern IIterator<UIElement> First();
	}
}
