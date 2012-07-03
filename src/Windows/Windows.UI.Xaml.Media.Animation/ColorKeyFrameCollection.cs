using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class ColorKeyFrameCollection : IVector<ColorKeyFrame>, IIterable<ColorKeyFrame>
	{
		public extern uint Size
		{
			get;
		}
		public extern ColorKeyFrameCollection();
		public extern ColorKeyFrame GetAt([In] uint index);
		public extern IVectorView<ColorKeyFrame> GetView();
		public extern bool IndexOf([In] ColorKeyFrame value, out uint index);
		public extern void SetAt([In] uint index, [In] ColorKeyFrame value);
		public extern void InsertAt([In] uint index, [In] ColorKeyFrame value);
		public extern void RemoveAt([In] uint index);
		public extern void Append([In] ColorKeyFrame value);
		public extern void RemoveAtEnd();
		public extern void Clear();
		public extern uint GetMany([In] uint startIndex, [Out] ColorKeyFrame[] items);
		public extern void ReplaceAll([In] ColorKeyFrame[] items);
		public extern IIterator<ColorKeyFrame> First();
	}
}
