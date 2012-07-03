using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation.Peers
{
	[ExclusiveTo(typeof(ItemAutomationPeer)), Guid(688279667u, 56893, 19775, 151, 180, 77, 111, 157, 83, 68, 77), Version(100794368u), WebHostHidden]
	internal interface IItemAutomationPeerFactory
	{
		ItemAutomationPeer CreateInstanceWithParentAndItem([In] object item, [In] ItemsControlAutomationPeer parent, [In] object outer, out object inner);
	}
}
