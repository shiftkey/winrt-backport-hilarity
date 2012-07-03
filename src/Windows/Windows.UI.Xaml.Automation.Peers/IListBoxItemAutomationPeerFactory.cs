using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;
namespace Windows.UI.Xaml.Automation.Peers
{
	[ExclusiveTo(typeof(ListBoxItemAutomationPeer)), Guid(1352637912u, 45226, 17471, 161, 16, 65, 32, 154, 244, 79, 28), Version(100794368u), WebHostHidden]
	internal interface IListBoxItemAutomationPeerFactory
	{
		ListBoxItemAutomationPeer CreateInstanceWithOwner([In] ListBoxItem owner, [In] object outer, out object inner);
	}
}
