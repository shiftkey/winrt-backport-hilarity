using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Popups
{
	[ExclusiveTo(typeof(PopupMenu)), Guid(1318831836u, 34829, 18428, 160, 161, 114, 182, 57, 230, 37, 89), Version(100794368u)]
	internal interface IPopupMenu
	{
		IVector<IUICommand> Commands
		{
			get;
		}
		IAsyncOperation<IUICommand> ShowAsync([In] Point invocationPoint);
		[Overload("ShowAsyncWithRect")]
		IAsyncOperation<IUICommand> ShowForSelectionAsync([In] Rect selection);
		[Overload("ShowAsyncWithRectAndPlacement")]
		IAsyncOperation<IUICommand> ShowForSelectionAsync([In] Rect selection, [In] Placement preferredPlacement);
	}
}
