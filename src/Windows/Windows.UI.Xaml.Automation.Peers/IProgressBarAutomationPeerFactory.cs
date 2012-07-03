using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;
namespace Windows.UI.Xaml.Automation.Peers
{
	[ExclusiveTo(typeof(ProgressBarAutomationPeer)), Guid(910588331u, 47119, 16820, 142, 234, 47, 82, 81, 188, 115, 156), Version(100794368u), WebHostHidden]
	internal interface IProgressBarAutomationPeerFactory
	{
		ProgressBarAutomationPeer CreateInstanceWithOwner([In] ProgressBar owner, [In] object outer, out object inner);
	}
}
