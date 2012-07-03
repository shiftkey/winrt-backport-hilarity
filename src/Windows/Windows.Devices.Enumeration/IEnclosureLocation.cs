using System;
using Windows.Foundation.Metadata;
namespace Windows.Devices.Enumeration
{
	[ExclusiveTo(typeof(EnclosureLocation)), Guid(1110706727u, 22544, 17820, 170, 187, 198, 94, 31, 129, 62, 207), Version(100794368u)]
	internal interface IEnclosureLocation
	{
		bool InDock
		{
			get;
		}
		bool InLid
		{
			get;
		}
		Panel Panel
		{
			get;
		}
	}
}
