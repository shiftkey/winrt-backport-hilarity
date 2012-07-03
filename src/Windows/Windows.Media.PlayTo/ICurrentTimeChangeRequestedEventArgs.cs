using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Media.PlayTo
{
	[ExclusiveTo(typeof(CurrentTimeChangeRequestedEventArgs)), Guid(2574324516u, 60871, 19445, 145, 246, 60, 134, 39, 219, 89, 229), Version(100794368u)]
	internal interface ICurrentTimeChangeRequestedEventArgs
	{
		TimeSpan Time
		{
			get;
		}
	}
}
