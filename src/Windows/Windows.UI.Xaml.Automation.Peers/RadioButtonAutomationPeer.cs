using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Provider;
using Windows.UI.Xaml.Controls;
namespace Windows.UI.Xaml.Automation.Peers
{
	[Composable(typeof(IRadioButtonAutomationPeerFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class RadioButtonAutomationPeer : ToggleButtonAutomationPeer, IRadioButtonAutomationPeer, ISelectionItemProvider
	{
		public extern bool IsSelected
		{
			get;
		}
		public extern IRawElementProviderSimple SelectionContainer
		{
			get;
		}
		public extern RadioButtonAutomationPeer([In] RadioButton owner);
		public extern void AddToSelection();
		public extern void RemoveFromSelection();
		public extern void Select();
	}
}
