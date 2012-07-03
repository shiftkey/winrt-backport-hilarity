using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Provider;
namespace Windows.UI.Xaml.Automation.Peers
{
	[Composable(typeof(IListViewItemDataAutomationPeerFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class ListViewItemDataAutomationPeer : SelectorItemAutomationPeer, IListViewItemDataAutomationPeer, IScrollItemProvider
	{
		public extern ListViewItemDataAutomationPeer([In] object item, [In] ListViewBaseAutomationPeer parent);
		public extern void ScrollIntoView();
	}
}
