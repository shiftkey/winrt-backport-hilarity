using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Provider;
using Windows.UI.Xaml.Controls.Primitives;
namespace Windows.UI.Xaml.Automation.Peers
{
	[Composable(typeof(IToggleButtonAutomationPeerFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class ToggleButtonAutomationPeer : ButtonBaseAutomationPeer, IToggleButtonAutomationPeer, IToggleProvider
	{
		public extern ToggleState ToggleState
		{
			get;
		}
		public extern ToggleButtonAutomationPeer([In] ToggleButton owner);
		public extern void Toggle();
	}
}
