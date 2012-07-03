using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Provider;
namespace Windows.UI.Xaml.Automation.Peers
{
	[Composable(typeof(IFlipViewItemDataAutomationPeerFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class FlipViewItemDataAutomationPeer : SelectorItemAutomationPeer, IFlipViewItemDataAutomationPeer, IScrollItemProvider
	{
		public extern FlipViewItemDataAutomationPeer([In] object item, [In] FlipViewAutomationPeer parent);
		public extern void ScrollIntoView();
	}
}
