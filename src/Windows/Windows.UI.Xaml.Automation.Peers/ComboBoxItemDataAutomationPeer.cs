using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Provider;
namespace Windows.UI.Xaml.Automation.Peers
{
	[Composable(typeof(IComboBoxItemDataAutomationPeerFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class ComboBoxItemDataAutomationPeer : SelectorItemAutomationPeer, IComboBoxItemDataAutomationPeer, IScrollItemProvider
	{
		public extern ComboBoxItemDataAutomationPeer([In] object item, [In] ComboBoxAutomationPeer parent);
		public extern void ScrollIntoView();
	}
}
