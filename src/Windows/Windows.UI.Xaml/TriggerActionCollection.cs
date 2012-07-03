using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class TriggerActionCollection : IVector<TriggerAction>, IIterable<TriggerAction>
	{
		public extern uint Size
		{
			get;
		}
		public extern TriggerActionCollection();
		public extern TriggerAction GetAt([In] uint index);
		public extern IVectorView<TriggerAction> GetView();
		public extern bool IndexOf([In] TriggerAction value, out uint index);
		public extern void SetAt([In] uint index, [In] TriggerAction value);
		public extern void InsertAt([In] uint index, [In] TriggerAction value);
		public extern void RemoveAt([In] uint index);
		public extern void Append([In] TriggerAction value);
		public extern void RemoveAtEnd();
		public extern void Clear();
		public extern uint GetMany([In] uint startIndex, [Out] TriggerAction[] items);
		public extern void ReplaceAll([In] TriggerAction[] items);
		public extern IIterator<TriggerAction> First();
	}
}
