using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
namespace Windows.UI.Xaml.Automation.Peers
{
	[Composable(typeof(IScrollBarAutomationPeerFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class ScrollBarAutomationPeer : RangeBaseAutomationPeer, IScrollBarAutomationPeer
	{
		public extern ScrollBarAutomationPeer([In] ScrollBar owner);
	}
}
