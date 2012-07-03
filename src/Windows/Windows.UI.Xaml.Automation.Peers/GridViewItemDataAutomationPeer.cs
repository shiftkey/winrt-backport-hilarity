using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Provider;
namespace Windows.UI.Xaml.Automation.Peers
{
	[Composable(typeof(IGridViewItemDataAutomationPeerFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class GridViewItemDataAutomationPeer : SelectorItemAutomationPeer, IGridViewItemDataAutomationPeer, IScrollItemProvider
	{
		public extern GridViewItemDataAutomationPeer([In] object item, [In] GridViewAutomationPeer parent);
		public extern void ScrollIntoView();
	}
}
