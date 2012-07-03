using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class RowDefinitionCollection : IVector<RowDefinition>, IIterable<RowDefinition>
	{
		public extern uint Size
		{
			get;
		}
		public extern RowDefinition GetAt([In] uint index);
		public extern IVectorView<RowDefinition> GetView();
		public extern bool IndexOf([In] RowDefinition value, out uint index);
		public extern void SetAt([In] uint index, [In] RowDefinition value);
		public extern void InsertAt([In] uint index, [In] RowDefinition value);
		public extern void RemoveAt([In] uint index);
		public extern void Append([In] RowDefinition value);
		public extern void RemoveAtEnd();
		public extern void Clear();
		public extern uint GetMany([In] uint startIndex, [Out] RowDefinition[] items);
		public extern void ReplaceAll([In] RowDefinition[] items);
		public extern IIterator<RowDefinition> First();
	}
}
