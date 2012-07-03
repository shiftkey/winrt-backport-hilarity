using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Peers;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(UIElement)), Guid(1619865373u, 30808, 19179, 137, 228, 181, 78, 44, 126, 211, 211), Version(100794368u), WebHostHidden]
	internal interface IUIElementOverrides
	{
		AutomationPeer OnCreateAutomationPeer();
		void OnDisconnectVisualChildren();
		IIterable<IIterable<Point>> FindSubElementsForTouchTargeting([In] Point point, [In] Rect boundingRect);
	}
}
