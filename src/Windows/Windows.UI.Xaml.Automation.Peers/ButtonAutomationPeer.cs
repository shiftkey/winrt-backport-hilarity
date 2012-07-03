using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Provider;
using Windows.UI.Xaml.Controls;
namespace Windows.UI.Xaml.Automation.Peers
{
	[Composable(typeof(IButtonAutomationPeerFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class ButtonAutomationPeer : ButtonBaseAutomationPeer, IButtonAutomationPeer, IInvokeProvider
	{
		public extern ButtonAutomationPeer([In] Button owner);
		public extern void Invoke();
	}
}
