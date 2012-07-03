using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Pickers
{
	[Version(100794368u)]
	public sealed class FileExtensionVector : IVector<string>, IIterable<string>
	{
		public extern uint Size
		{
			get;
		}
		public extern string GetAt([In] uint index);
		public extern IVectorView<string> GetView();
		public extern bool IndexOf([In] string value, out uint index);
		public extern void SetAt([In] uint index, [In] string value);
		public extern void InsertAt([In] uint index, [In] string value);
		public extern void RemoveAt([In] uint index);
		public extern void Append([In] string value);
		public extern void RemoveAtEnd();
		public extern void Clear();
		public extern uint GetMany([In] uint startIndex, [Out] string[] items);
		public extern void ReplaceAll([In] string[] items);
		public extern IIterator<string> First();
	}
}
