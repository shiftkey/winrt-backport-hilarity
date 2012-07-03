using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class ObjectKeyFrameCollection : IVector<ObjectKeyFrame>, IIterable<ObjectKeyFrame>
	{
		public extern uint Size
		{
			get;
		}
		public extern ObjectKeyFrameCollection();
		public extern ObjectKeyFrame GetAt([In] uint index);
		public extern IVectorView<ObjectKeyFrame> GetView();
		public extern bool IndexOf([In] ObjectKeyFrame value, out uint index);
		public extern void SetAt([In] uint index, [In] ObjectKeyFrame value);
		public extern void InsertAt([In] uint index, [In] ObjectKeyFrame value);
		public extern void RemoveAt([In] uint index);
		public extern void Append([In] ObjectKeyFrame value);
		public extern void RemoveAtEnd();
		public extern void Clear();
		public extern uint GetMany([In] uint startIndex, [Out] ObjectKeyFrame[] items);
		public extern void ReplaceAll([In] ObjectKeyFrame[] items);
		public extern IIterator<ObjectKeyFrame> First();
	}
}
