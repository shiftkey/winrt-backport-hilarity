using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Popups;
namespace Windows.UI.Core
{
	[ExclusiveTo(typeof(CoreWindowDialog)), Guid(3879283936u, 51085, 17022, 139, 44, 1, 255, 66, 12, 105, 213), Version(100794368u), WebHostHidden]
	internal interface ICoreWindowDialog
	{
		event TypedEventHandler<CoreWindow, CoreWindowPopupShowingEventArgs> Showing;
		UICommandInvokedHandler BackButtonCommand
		{
			get;
			set;
		}
		uint CancelCommandIndex
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
