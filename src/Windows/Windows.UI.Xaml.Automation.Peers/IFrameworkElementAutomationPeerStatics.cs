using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation.Peers
{
	[ExclusiveTo(typeof(FrameworkElementAutomationPeer)), Guid(3116415383u, 10272, 17569, 165, 168, 155, 128, 30, 220, 38, 158), Version(100794368u), WebHostHidden]
	internal interface IFrameworkElementAutomationPeerStatics
	{
		AutomationPeer FromElement([In] UIElement element);
		AutomationPeer CreatePeerForElement([In] UIElement element);
	}
}
