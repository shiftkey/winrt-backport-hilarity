using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class SetterBaseCollection : ISetterBaseCollection, IVector<SetterBase>, IIterable<SetterBase>
	{
		public extern bool IsSealed
		{
			get;
		}
		public extern uint Size
		{
			get;
		}
		public extern SetterBaseCollection();
		public extern SetterBase GetAt([In] uint index);
		public extern IVectorView<SetterBase> GetView();
		public extern bool IndexOf([In] SetterBase value, out uint index);
		public extern void SetAt([In] uint index, [In] SetterBase value);
		public extern void InsertAt([In] uint index, [In] SetterBase value);
		public extern void RemoveAt([In] uint index);
		public extern void Append([In] SetterBase value);
		public extern void RemoveAtEnd();
		public extern void Clear();
		public extern uint GetMany([In] uint startIndex, [Out] SetterBase[] items);
		public extern void ReplaceAll([In] SetterBase[] items);
		public extern IIterator<SetterBase> First();
	}
}
