using System;
using Windows.Foundation.Metadata;
namespace Windows.Foundation
{
	[Guid(819308585u, 32676, 16422, 131, 187, 215, 91, 174, 78, 169, 158), Version(100794368u)]
	public interface IClosable
	{
		void Close();
	}
}
