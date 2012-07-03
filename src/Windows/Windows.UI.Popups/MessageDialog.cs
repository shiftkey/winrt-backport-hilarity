using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Popups
{
	[Activatable(typeof(IMessageDialogFactory), 100794368u), MarshalingBehavior(MarshalingType.Standard), Version(100794368u)]
	public sealed class MessageDialog : IMessageDialog
	{
		public extern uint CancelCommandIndex
		{
			get;
			set;
		}
		public extern IVector<IUICommand> Commands
		{
			get;
		}
		public extern string Content
		{
			get;
			set;
		}
		public extern uint DefaultCommandIndex
		{
			get;
			set;
		}
		public extern MessageDialogOptions Options
		{
			get;
			set;
		}
		public extern string Title
		{
			get;
			set;
		}
		public extern MessageDialog([In] string content);
		public extern MessageDialog([In] string content, [In] string title);
		public extern IAsyncOperation<IUICommand> ShowAsync();
	}
}
