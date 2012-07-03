using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class TransitionCollection : IVector<Transition>, IIterable<Transition>
	{
		public extern uint Size
		{
			get;
		}
		public extern TransitionCollection();
		public extern Transition GetAt([In] uint index);
		public extern IVectorView<Transition> GetView();
		public extern bool IndexOf([In] Transition value, out uint index);
		public extern void SetAt([In] uint index, [In] Transition value);
		public extern void InsertAt([In] uint index, [In] Transition value);
		public extern void RemoveAt([In] uint index);
		public extern void Append([In] Transition value);
		public extern void RemoveAtEnd();
		public extern void Clear();
		public extern uint GetMany([In] uint startIndex, [Out] Transition[] items);
		public extern void ReplaceAll([In] Transition[] items);
		public extern IIterator<Transition> First();
	}
}
