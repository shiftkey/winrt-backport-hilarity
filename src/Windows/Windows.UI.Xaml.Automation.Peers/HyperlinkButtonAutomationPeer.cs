using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Provider;
using Windows.UI.Xaml.Controls;
namespace Windows.UI.Xaml.Automation.Peers
{
	[Composable(typeof(IHyperlinkButtonAutomationPeerFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class HyperlinkButtonAutomationPeer : ButtonBaseAutomationPeer, IHyperlinkButtonAutomationPeer, IInvokeProvider
	{
		public extern HyperlinkButtonAutomationPeer([In] HyperlinkButton owner);
		public extern void Invoke();
	}
}
