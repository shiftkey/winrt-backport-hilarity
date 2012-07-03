using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;
namespace Windows.UI.Xaml.Automation.Peers
{
	[ExclusiveTo(typeof(ListBoxAutomationPeer)), Guid(3795198341u, 32246, 18935, 138, 188, 76, 51, 241, 163, 212, 110), Version(100794368u), WebHostHidden]
	internal interface IListBoxAutomationPeerFactory
	{
		ListBoxAutomationPeer CreateInstanceWithOwner([In] ListBox owner, [In] object outer, out object inner);
	}
}
