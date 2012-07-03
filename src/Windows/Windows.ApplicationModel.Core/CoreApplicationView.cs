using System;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;
namespace Windows.ApplicationModel.Core
{
	[MarshalingBehavior(MarshalingType.Standard), Version(100794368u), WebHostHidden]
	public sealed class CoreApplicationView : ICoreApplicationView
	{
		public extern event TypedEventHandler<CoreApplicationView, IActivatedEventArgs> Activated
		{
			add;
			remove;
		}
		public extern CoreWindow CoreWindow
		{
			get;
		}
		public extern bool IsHosted
		{
			get;
		}
		public extern bool IsMain
		{
			get;
		}
	}
}
