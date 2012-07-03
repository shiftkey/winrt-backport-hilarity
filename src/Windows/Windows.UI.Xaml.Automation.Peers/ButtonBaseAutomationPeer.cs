using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
namespace Windows.UI.Xaml.Automation.Peers
{
	[Composable(typeof(IButtonBaseAutomationPeerFactory), CompositionType.Protected, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class ButtonBaseAutomationPeer : FrameworkElementAutomationPeer, IButtonBaseAutomationPeer
	{
		protected extern ButtonBaseAutomationPeer([In] ButtonBase owner);
	}
}
