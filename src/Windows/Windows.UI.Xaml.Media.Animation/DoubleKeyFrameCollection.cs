using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class DoubleKeyFrameCollection : IVector<DoubleKeyFrame>, IIterable<DoubleKeyFrame>
	{
		public extern uint Size
		{
			get;
		}
		public extern DoubleKeyFrameCollection();
		public extern DoubleKeyFrame GetAt([In] uint index);
		public extern IVectorView<DoubleKeyFrame> GetView();
		public extern bool IndexOf([In] DoubleKeyFrame value, out uint index);
		public extern void SetAt([In] uint index, [In] DoubleKeyFrame value);
		public extern void InsertAt([In] uint index, [In] DoubleKeyFrame value);
		public extern void RemoveAt([In] uint index);
		public extern void Append([In] DoubleKeyFrame value);
		public extern void RemoveAtEnd();
		public extern void Clear();
		public extern uint GetMany([In] uint startIndex, [Out] DoubleKeyFrame[] items);
		public extern void ReplaceAll([In] DoubleKeyFrame[] items);
		public extern IIterator<DoubleKeyFrame> First();
	}
}
