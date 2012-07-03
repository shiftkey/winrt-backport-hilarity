using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Foundation.Collections
{
	[Guid(1786374243u, 17152, 17818, 153, 102, 203, 182, 96, 150, 62, 225), Version(100794368u)]
	public interface IIterator<T>
	{
		T Current
		{
			get;
		}
		bool HasCurrent
		{
			get;
		}
		bool MoveNext();
		uint GetMany([LengthIs(0u)] [Out] T[] items);
	}
}
