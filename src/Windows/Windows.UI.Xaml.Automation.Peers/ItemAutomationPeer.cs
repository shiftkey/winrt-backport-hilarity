using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Provider;
namespace Windows.UI.Xaml.Automation.Peers
{
	[Composable(typeof(IItemAutomationPeerFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class ItemAutomationPeer : AutomationPeer, IItemAutomationPeer, IVirtualizedItemProvider
	{
		public extern object Item
		{
			get;
		}
		public extern ItemsControlAutomationPeer ItemsControlAutomationPeer
		{
			get;
		}
		public extern ItemAutomationPeer([In] object item, [In] ItemsControlAutomationPeer parent);
		public extern void Realize();
	}
}
