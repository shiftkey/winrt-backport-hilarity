using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation.Peers
{
	[ExclusiveTo(typeof(AutomationPeer)), Guid(1445953456u, 41777, 19100, 157, 236, 191, 183, 88, 111, 255, 255), Version(100794368u), WebHostHidden]
	internal interface IAutomationPeerStatics
	{
		bool ListenerExists([In] AutomationEvents eventId);
	}
}
