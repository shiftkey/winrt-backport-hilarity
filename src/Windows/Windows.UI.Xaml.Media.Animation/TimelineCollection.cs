using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class TimelineCollection : IVector<Timeline>, IIterable<Timeline>
	{
		public extern uint Size
		{
			get;
		}
		public extern TimelineCollection();
		public extern Timeline GetAt([In] uint index);
		public extern IVectorView<Timeline> GetView();
		public extern bool IndexOf([In] Timeline value, out uint index);
		public extern void SetAt([In] uint index, [In] Timeline value);
		public extern void InsertAt([In] uint index, [In] Timeline value);
		public extern void RemoveAt([In] uint index);
		public extern void Append([In] Timeline value);
		public extern void RemoveAtEnd();
		public extern void Clear();
		public extern uint GetMany([In] uint startIndex, [Out] Timeline[] items);
		public extern void ReplaceAll([In] Timeline[] items);
		public extern IIterator<Timeline> First();
	}
}
