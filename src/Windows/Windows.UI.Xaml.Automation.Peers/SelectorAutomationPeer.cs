using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Provider;
using Windows.UI.Xaml.Controls.Primitives;
namespace Windows.UI.Xaml.Automation.Peers
{
	[Composable(typeof(ISelectorAutomationPeerFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class SelectorAutomationPeer : ItemsControlAutomationPeer, ISelectorAutomationPeer, ISelectionProvider
	{
		public extern bool CanSelectMultiple
		{
			get;
		}
		public extern bool IsSelectionRequired
		{
			get;
		}
		public extern SelectorAutomationPeer([In] Selector owner);
		public extern IRawElementProviderSimple[] GetSelection();
	}
}
