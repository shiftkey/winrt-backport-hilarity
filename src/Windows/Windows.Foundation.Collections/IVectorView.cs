using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Foundation.Collections
{
	[Guid(3152149068u, 45283, 17795, 186, 239, 31, 27, 46, 72, 62, 86), Version(100794368u)]
	public interface IVectorView<T> : IIterable<T>
	{
		uint Size
		{
			get;
		}
		T GetAt([In] uint index);
		bool IndexOf([In] T value, out uint index);
		uint GetMany([In] uint startIndex, [LengthIs(0u)] [Out] T[] items);
	}
}
