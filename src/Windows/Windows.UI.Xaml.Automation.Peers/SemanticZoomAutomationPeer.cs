using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Provider;
using Windows.UI.Xaml.Controls;
namespace Windows.UI.Xaml.Automation.Peers
{
	[Composable(typeof(ISemanticZoomAutomationPeerFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class SemanticZoomAutomationPeer : FrameworkElementAutomationPeer, ISemanticZoomAutomationPeer, IToggleProvider
	{
		public extern ToggleState ToggleState
		{
			get;
		}
		public extern SemanticZoomAutomationPeer([In] SemanticZoom owner);
		public extern void Toggle();
	}
}
