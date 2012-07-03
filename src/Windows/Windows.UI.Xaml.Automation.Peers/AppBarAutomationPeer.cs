using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Provider;
using Windows.UI.Xaml.Controls;
namespace Windows.UI.Xaml.Automation.Peers
{
	[Composable(typeof(IAppBarAutomationPeerFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class AppBarAutomationPeer : FrameworkElementAutomationPeer, IAppBarAutomationPeer, IToggleProvider
	{
		public extern ToggleState ToggleState
		{
			get;
		}
		public extern AppBarAutomationPeer([In] AppBar owner);
		public extern void Toggle();
	}
}
