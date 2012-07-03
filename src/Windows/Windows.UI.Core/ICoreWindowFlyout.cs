using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Popups;
namespace Windows.UI.Core
{
	[ExclusiveTo(typeof(CoreWindowFlyout)), Guid(3902637389u, 8272, 16571, 179, 68, 246, 243, 85, 238, 179, 20), Version(100794368u), WebHostHidden]
	internal interface ICoreWindowFlyout
	{
		event TypedEventHandler<CoreWindow, CoreWindowPopupShowingEventArgs> Showing;
		UICommandInvokedHandler BackButtonCommand
		{
			get;
			set;
		}
		IVector<IUICommand> Commands
		{
			get;
		}
		uint DefaultCommandIndex
		{
			get;
			set;
		}
		int IsInteractionDelayed
		{
			get;
			set;
		}
		Size MaxSize
		{
			get;
		}
		Size MinSize
		{
			get;
		}
		string Title
		{
			get;
			set;
		}
		IAsyncOperation<IUICommand> ShowAsync();
	}
}
