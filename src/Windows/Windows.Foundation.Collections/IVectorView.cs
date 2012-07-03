using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Foundation.Collections
{
	public interface IVectorView<T> : IIterable<T>
	{
		uint Size { get; }
		T GetAt([In] uint index);
		bool IndexOf([In] T value, out uint index);
		uint GetMany([In] uint startIndex, [LengthIs(0)] [Out] T[] items);
	}
}
