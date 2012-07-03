using System;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;
namespace Windows.ApplicationModel.Core
{
	[ExclusiveTo(typeof(CoreApplicationView)), Guid(1670099675u, 17693, 18017, 176, 153, 65, 79, 52, 255, 185, 241), Version(100794368u), WebHostHidden]
	internal interface ICoreApplicationView
	{
		event TypedEventHandler<CoreApplicationView, IActivatedEventArgs> Activated;
		CoreWindow CoreWindow
		{
			get;
		}
		bool IsHosted
		{
			get;
		}
		bool IsMain
		{
			get;
		}
	}
}
