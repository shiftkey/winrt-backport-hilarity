using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Provider;
using Windows.UI.Xaml.Controls;
namespace Windows.UI.Xaml.Automation.Peers
{
	[Composable(typeof(IComboBoxAutomationPeerFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class ComboBoxAutomationPeer : SelectorAutomationPeer, IComboBoxAutomationPeer, IValueProvider, IExpandCollapseProvider
	{
		public extern bool IsReadOnly
		{
			get;
		}
		public extern string Value
		{
			get;
		}
		public extern ExpandCollapseState ExpandCollapseState
		{
			get;
		}
		public extern ComboBoxAutomationPeer([In] ComboBox owner);
		public extern void SetValue([In] string value);
		public extern void Collapse();
		public extern void Expand();
	}
}
