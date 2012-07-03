using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Provider;
namespace Windows.UI.Xaml.Automation.Peers
{
	[Composable(typeof(IListBoxItemDataAutomationPeerFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class ListBoxItemDataAutomationPeer : SelectorItemAutomationPeer, IListBoxItemDataAutomationPeer, IScrollItemProvider
	{
		public extern ListBoxItemDataAutomationPeer([In] object item, [In] ListBoxAutomationPeer parent);
		public extern void ScrollIntoView();
	}
}
