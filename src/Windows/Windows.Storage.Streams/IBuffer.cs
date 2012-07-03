using System;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Streams
{
	[Guid(2421821408u, 48211, 4575, 140, 73, 0, 30, 79, 198, 134, 218), Version(100794368u)]
	public interface IBuffer
	{
		uint Capacity
		{
			get;
		}
		uint Length
		{
			get;
			set;
		}
	}
}
