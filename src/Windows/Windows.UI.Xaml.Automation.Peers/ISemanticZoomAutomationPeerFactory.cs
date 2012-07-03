using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;
namespace Windows.UI.Xaml.Automation.Peers
{
	[ExclusiveTo(typeof(SemanticZoomAutomationPeer)), Guid(4112045133u, 42131, 17558, 176, 119, 150, 116, 199, 244, 197, 250), Version(100794368u), WebHostHidden]
	internal interface ISemanticZoomAutomationPeerFactory
	{
		SemanticZoomAutomationPeer CreateInstanceWithOwner([In] SemanticZoom owner, [In] object outer, out object inner);
	}
}
