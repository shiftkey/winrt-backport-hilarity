using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;
namespace Windows.UI.Xaml.Automation.Peers
{
	[ExclusiveTo(typeof(ButtonAutomationPeer)), Guid(1071357769u, 62635, 18304, 134, 68, 3, 55, 98, 153, 161, 117), Version(100794368u), WebHostHidden]
	internal interface IButtonAutomationPeerFactory
	{
		ButtonAutomationPeer CreateInstanceWithOwner([In] Button owner, [In] object outer, out object inner);
	}
}
