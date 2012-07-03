using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Activation
{
	[ExclusiveTo(typeof(SplashScreen)), Guid(3394082652u, 54486, 17392, 151, 192, 8, 51, 198, 57, 28, 36), Version(100794368u)]
	internal interface ISplashScreen
	{
		event TypedEventHandler<SplashScreen, object> Dismissed;
		Rect ImageLocation
		{
			get;
		}
	}
}
