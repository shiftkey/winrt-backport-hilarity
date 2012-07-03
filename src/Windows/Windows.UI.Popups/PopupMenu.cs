using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Popups
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Standard), Version(100794368u)]
	public sealed class PopupMenu : IPopupMenu
	{
		public extern IVector<IUICommand> Commands
		{
			get;
		}
		public extern PopupMenu();
		public extern IAsyncOperation<IUICommand> ShowAsync([In] Point invocationPoint);
		[Overload("ShowAsyncWithRect")]
		public extern IAsyncOperation<IUICommand> ShowForSelectionAsync([In] Rect selection);
		[Overload("ShowAsyncWithRectAndPlacement")]
		public extern IAsyncOperation<IUICommand> ShowForSelectionAsync([In] Rect selection, [In] Placement preferredPlacement);
	}
}
