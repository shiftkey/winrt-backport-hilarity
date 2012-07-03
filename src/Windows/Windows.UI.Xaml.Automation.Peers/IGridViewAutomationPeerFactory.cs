using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;
namespace Windows.UI.Xaml.Automation.Peers
{
	[ExclusiveTo(typeof(GridViewAutomationPeer)), Guid(2328517085u, 8871, 18432, 137, 75, 193, 244, 133, 243, 137, 83), Version(100794368u), WebHostHidden]
	internal interface IGridViewAutomationPeerFactory
	{
		GridViewAutomationPeer CreateInstanceWithOwner([In] GridView owner, [In] object outer, out object inner);
	}
}
