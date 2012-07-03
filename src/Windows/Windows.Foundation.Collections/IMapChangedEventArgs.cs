using System;
using Windows.Foundation.Metadata;
namespace Windows.Foundation.Collections
{
	[Guid(2570712287u, 1290, 19471, 170, 96, 119, 7, 95, 156, 71, 119), Version(100794368u)]
	public interface IMapChangedEventArgs<K>
	{
		CollectionChange CollectionChange
		{
			get;
		}
		K Key
		{
			get;
		}
	}
}
