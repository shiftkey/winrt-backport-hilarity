using System;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel
{
	[ExclusiveTo(typeof(DesignMode)), Guid(741905356u, 63514, 20090, 184, 87, 118, 168, 8, 135, 225, 133), Version(100794368u)]
	internal interface IDesignModeStatics
	{
		bool DesignModeEnabled
		{
			get;
		}
	}
}
