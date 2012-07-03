using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation.Peers
{
	[Composable(typeof(IFrameworkElementAutomationPeerFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IFrameworkElementAutomationPeerStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class FrameworkElementAutomationPeer : AutomationPeer, IFrameworkElementAutomationPeer
	{
		public extern UIElement Owner
		{
			get;
		}
		public extern FrameworkElementAutomationPeer([In] FrameworkElement owner);
		public static extern AutomationPeer FromElement([In] UIElement element);
		public static extern AutomationPeer CreatePeerForElement([In] UIElement element);
	}
}
