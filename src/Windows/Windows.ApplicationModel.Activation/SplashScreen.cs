using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Activation
{
	[Version(100794368u)]
	public sealed class SplashScreen : ISplashScreen
	{
		public extern event TypedEventHandler<SplashScreen, object> Dismissed
		{
			add;
			remove;
		}
		public extern Rect ImageLocation
		{
			get;
		}
	}
}
