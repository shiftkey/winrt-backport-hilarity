using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class TriggerCollection : IVector<TriggerBase>, IIterable<TriggerBase>
	{
		public extern uint Size
		{
			get;
		}
		public extern TriggerBase GetAt([In] uint index);
		public extern IVectorView<TriggerBase> GetView();
		public extern bool IndexOf([In] TriggerBase value, out uint index);
		public extern void SetAt([In] uint index, [In] TriggerBase value);
		public extern void InsertAt([In] uint index, [In] TriggerBase value);
		public extern void RemoveAt([In] uint index);
		public extern void Append([In] TriggerBase value);
		public extern void RemoveAtEnd();
		public extern void Clear();
		public extern uint GetMany([In] uint startIndex, [Out] TriggerBase[] items);
		public extern void ReplaceAll([In] TriggerBase[] items);
		public extern IIterator<TriggerBase> First();
	}
}
