using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Provider;
namespace Windows.UI.Xaml.Automation.Peers
{
	[Composable(typeof(ISelectorItemAutomationPeerFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class SelectorItemAutomationPeer : ItemAutomationPeer, ISelectorItemAutomationPeer, ISelectionItemProvider
	{
		public extern bool IsSelected
		{
			get;
		}
		public extern IRawElementProviderSimple SelectionContainer
		{
			get;
		}
		public extern SelectorItemAutomationPeer([In] object item, [In] SelectorAutomationPeer parent);
		public extern void AddToSelection();
		public extern void RemoveFromSelection();
		public extern void Select();
	}
}
