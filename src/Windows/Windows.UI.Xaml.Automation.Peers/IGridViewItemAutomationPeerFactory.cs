using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;
namespace Windows.UI.Xaml.Automation.Peers
{
	[ExclusiveTo(typeof(GridViewItemAutomationPeer)), Guid(4211000182u, 61998, 18029, 145, 60, 174, 36, 204, 219, 22, 15), Version(100794368u), WebHostHidden]
	internal interface IGridViewItemAutomationPeerFactory
	{
		GridViewItemAutomationPeer CreateInstanceWithOwner([In] GridViewItem owner, [In] object outer, out object inner);
	}
}
