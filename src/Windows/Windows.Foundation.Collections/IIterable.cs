using System;
using Windows.Foundation.Metadata;
namespace Windows.Foundation.Collections
{
	[Guid(4205151722u, 25108, 16919, 175, 218, 127, 70, 222, 88, 105, 179), Version(100794368u)]
	public interface IIterable<T>
	{
		IIterator<T> First();
	}
}
