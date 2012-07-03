using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
namespace Windows.UI.Xaml.Automation.Peers
{
	[ExclusiveTo(typeof(RepeatButtonAutomationPeer)), Guid(1785723348u, 22366, 20064, 189, 214, 236, 20, 65, 155, 79, 246), Version(100794368u), WebHostHidden]
	internal interface IRepeatButtonAutomationPeerFactory
	{
		RepeatButtonAutomationPeer CreateInstanceWithOwner([In] RepeatButton owner, [In] object outer, out object inner);
	}
}
