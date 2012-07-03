using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(RenderingEventArgs)), Guid(1542968077u, 38728, 19181, 131, 128, 215, 137, 14, 183, 118, 160), Version(100794368u), WebHostHidden]
	internal interface IRenderingEventArgs
	{
		TimeSpan RenderingTime
		{
			get;
		}
	}
}
