using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;
namespace Windows.UI.Xaml.Automation.Peers
{
	[Composable(typeof(IGridViewItemAutomationPeerFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class GridViewItemAutomationPeer : FrameworkElementAutomationPeer, IGridViewItemAutomationPeer
	{
		public extern GridViewItemAutomationPeer([In] GridViewItem owner);
	}
}
