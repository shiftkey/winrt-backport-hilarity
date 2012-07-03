using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Popups
{
	[Guid(3673651791u, 49786, 17048, 154, 198, 41, 34, 196, 94, 125, 166), Version(100794368u)]
	public delegate void UICommandInvokedHandler([In] IUICommand command);
}
