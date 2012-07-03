using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Provider;
using Windows.UI.Xaml.Controls.Primitives;
namespace Windows.UI.Xaml.Automation.Peers
{
	[Composable(typeof(IRepeatButtonAutomationPeerFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class RepeatButtonAutomationPeer : ButtonBaseAutomationPeer, IRepeatButtonAutomationPeer, IInvokeProvider
	{
		public extern RepeatButtonAutomationPeer([In] RepeatButton owner);
		public extern void Invoke();
	}
}
