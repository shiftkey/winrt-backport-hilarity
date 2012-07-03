using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation.Peers
{
	[ExclusiveTo(typeof(SelectorItemAutomationPeer)), Guid(1725427195u, 30829, 17250, 169, 100, 235, 251, 33, 119, 108, 48), Version(100794368u), WebHostHidden]
	internal interface ISelectorItemAutomationPeerFactory
	{
		SelectorItemAutomationPeer CreateInstanceWithParentAndItem([In] object item, [In] SelectorAutomationPeer parent, [In] object outer, out object inner);
	}
}
