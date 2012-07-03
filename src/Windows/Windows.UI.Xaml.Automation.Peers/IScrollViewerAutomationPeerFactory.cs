using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;
namespace Windows.UI.Xaml.Automation.Peers
{
	[ExclusiveTo(typeof(ScrollViewerAutomationPeer)), Guid(655228797u, 55661, 18681, 163, 106, 194, 82, 170, 156, 70, 112), Version(100794368u), WebHostHidden]
	internal interface IScrollViewerAutomationPeerFactory
	{
		ScrollViewerAutomationPeer CreateInstanceWithOwner([In] ScrollViewer owner, [In] object outer, out object inner);
	}
}
