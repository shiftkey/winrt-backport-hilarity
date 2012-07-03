using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class PointKeyFrameCollection : IVector<PointKeyFrame>, IIterable<PointKeyFrame>
	{
		public extern uint Size
		{
			get;
		}
		public extern PointKeyFrameCollection();
		public extern PointKeyFrame GetAt([In] uint index);
		public extern IVectorView<PointKeyFrame> GetView();
		public extern bool IndexOf([In] PointKeyFrame value, out uint index);
		public extern void SetAt([In] uint index, [In] PointKeyFrame value);
		public extern void InsertAt([In] uint index, [In] PointKeyFrame value);
		public extern void RemoveAt([In] uint index);
		public extern void Append([In] PointKeyFrame value);
		public extern void RemoveAtEnd();
		public extern void Clear();
		public extern uint GetMany([In] uint startIndex, [Out] PointKeyFrame[] items);
		public extern void ReplaceAll([In] PointKeyFrame[] items);
		public extern IIterator<PointKeyFrame> First();
	}
}
