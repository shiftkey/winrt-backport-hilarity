using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class ColumnDefinitionCollection : IVector<ColumnDefinition>, IIterable<ColumnDefinition>
	{
		public extern uint Size
		{
			get;
		}
		public extern ColumnDefinition GetAt([In] uint index);
		public extern IVectorView<ColumnDefinition> GetView();
		public extern bool IndexOf([In] ColumnDefinition value, out uint index);
		public extern void SetAt([In] uint index, [In] ColumnDefinition value);
		public extern void InsertAt([In] uint index, [In] ColumnDefinition value);
		public extern void RemoveAt([In] uint index);
		public extern void Append([In] ColumnDefinition value);
		public extern void RemoveAtEnd();
		public extern void Clear();
		public extern uint GetMany([In] uint startIndex, [Out] ColumnDefinition[] items);
		public extern void ReplaceAll([In] ColumnDefinition[] items);
		public extern IIterator<ColumnDefinition> First();
	}
}
