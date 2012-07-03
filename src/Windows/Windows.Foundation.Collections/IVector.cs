using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Foundation.Collections
{
	public interface IVector<T> : IIterable<T>
	{
		uint Size
		{
			get;
		}
		T GetAt([In] uint index);
		IVectorView<T> GetView();
		bool IndexOf([In] T value, out uint index);
		void SetAt([In] uint index, [In] T value);
		void InsertAt([In] uint index, [In] T value);
		void RemoveAt([In] uint index);
		void Append([In] T value);
		void RemoveAtEnd();
		void Clear();
		uint GetMany([In] uint startIndex, [LengthIs(0)] [Out] T[] items);
		void ReplaceAll([In] T[] items);
	}
}
