using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;
namespace Windows.UI.Xaml.Automation.Peers
{
	[Composable(typeof(IFlipViewItemAutomationPeerFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class FlipViewItemAutomationPeer : FrameworkElementAutomationPeer, IFlipViewItemAutomationPeer
	{
		public extern FlipViewItemAutomationPeer([In] FlipViewItem owner);
	}
}
