using System;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Pickers.Provider
{
	[ExclusiveTo(typeof(TargetFileRequestDeferral)), Guid(1257151889u, 48917, 19881, 149, 246, 246, 183, 213, 88, 34, 91), Version(100794368u)]
	internal interface ITargetFileRequestDeferral
	{
		void Complete();
	}
}
