using System;
using Windows.Foundation.Metadata;
namespace Windows.Storage
{
	[ExclusiveTo(typeof(ApplicationData)), Guid(1444025467u, 59459, 17891, 148, 216, 6, 22, 158, 60, 142, 23), Version(100794368u)]
	internal interface IApplicationDataStatics
	{
		ApplicationData Current
		{
			get;
		}
	}
}
