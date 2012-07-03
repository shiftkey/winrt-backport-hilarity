using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Provider;
namespace Windows.UI.Xaml.Automation.Peers
{
	[ExclusiveTo(typeof(AutomationPeer)), Guid(4105440850u, 25647, 17961, 165, 74, 234, 93, 35, 73, 196, 72), Version(100794368u), WebHostHidden]
	internal interface IAutomationPeerProtected
	{
		AutomationPeer PeerFromProvider([In] IRawElementProviderSimple provider);
		IRawElementProviderSimple ProviderFromPeer([In] AutomationPeer peer);
	}
}
