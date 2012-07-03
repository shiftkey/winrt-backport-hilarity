using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Popups
{
	[ExclusiveTo(typeof(MessageDialog)), Guid(871734017u, 21285, 17323, 154, 179, 189, 174, 68, 14, 65, 33), Version(100794368u)]
	internal interface IMessageDialog
	{
		uint CancelCommandIndex
		{
			get;
			set;
		}
		IVector<IUICommand> Commands
		{
			get;
		}
		string Content
		{
			get;
			set;
		}
		uint DefaultCommandIndex
		{
			get;
			set;
		}
		MessageDialogOptions Options
		{
			get;
			set;
		}
		string Title
		{
			get;
			set;
		}
		IAsyncOperation<IUICommand> ShowAsync();
	}
}
