using System;
using Windows.Foundation.Metadata;
namespace Windows.Foundation.Collections
{
	[Guid(1465463775u, 13566, 17536, 175, 21, 7, 105, 31, 61, 93, 155), Version(100794368u)]
	public interface IVectorChangedEventArgs
	{
		CollectionChange CollectionChange
		{
			get;
		}
		uint Index
		{
			get;
		}
	}
}
