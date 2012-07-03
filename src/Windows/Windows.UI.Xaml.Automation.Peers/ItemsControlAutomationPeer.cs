using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Provider;
using Windows.UI.Xaml.Controls;
namespace Windows.UI.Xaml.Automation.Peers
{
	[Composable(typeof(IItemsControlAutomationPeerFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class ItemsControlAutomationPeer : FrameworkElementAutomationPeer, IItemsControlAutomationPeer, IItemContainerProvider
	{
		public extern ItemsControlAutomationPeer([In] ItemsControl owner);
		public extern IRawElementProviderSimple FindItemByProperty([In] IRawElementProviderSimple startAfter, [In] AutomationProperty automationProperty, [In] object value);
	}
}
