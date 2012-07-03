using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
namespace Windows.UI.Xaml.Automation.Peers
{
	[Composable(typeof(IThumbAutomationPeerFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class ThumbAutomationPeer : FrameworkElementAutomationPeer, IThumbAutomationPeer
	{
		public extern ThumbAutomationPeer([In] Thumb owner);
	}
}
