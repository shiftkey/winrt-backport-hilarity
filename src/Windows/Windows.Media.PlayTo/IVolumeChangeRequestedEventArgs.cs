using System;
using Windows.Foundation.Metadata;
namespace Windows.Media.PlayTo
{
	[ExclusiveTo(typeof(VolumeChangeRequestedEventArgs)), Guid(1862430044u, 53109, 19499, 145, 62, 109, 124, 108, 50, 145, 121), Version(100794368u)]
	internal interface IVolumeChangeRequestedEventArgs
	{
		double Volume
		{
			get;
		}
	}
}
