using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Storage.FileProperties
{
	[ExclusiveTo(typeof(BasicProperties)), Guid(3495777755u, 30814, 19046, 190, 2, 155, 238, 197, 138, 234, 129), Version(100794368u)]
	internal interface IBasicProperties
	{
		DateTime DateModified
		{
			get;
		}
		DateTime ItemDate
		{
			get;
		}
		ulong Size
		{
			get;
		}
	}
}
