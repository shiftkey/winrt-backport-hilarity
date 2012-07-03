using System;
using Windows.Foundation.Metadata;
namespace Windows.Storage
{
	[ExclusiveTo(typeof(SetVersionDeferral)), Guid(53807266u, 30746, 17274, 176, 120, 63, 50, 186, 220, 254, 71), Version(100794368u)]
	internal interface ISetVersionDeferral
	{
		void Complete();
	}
}
