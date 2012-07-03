using System;
using Windows.Foundation.Metadata;
namespace Windows.Foundation.Collections
{
	[Guid(45422889u, 49604, 19070, 137, 64, 3, 18, 181, 193, 133, 0), Version(100794368u)]
	public interface IKeyValuePair<K, V>
	{
		K Key
		{
			get;
		}
		V Value
		{
			get;
		}
	}
}
