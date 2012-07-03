using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Provider;
using Windows.UI.Xaml.Controls;
namespace Windows.UI.Xaml.Automation.Peers
{
	[Composable(typeof(IListViewBaseAutomationPeerFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class ListViewBaseAutomationPeer : SelectorAutomationPeer, IListViewBaseAutomationPeer, IDropTargetProvider
	{
		public extern string DropEffect
		{
			get;
		}
		public extern string[] DropEffects
		{
			get;
		}
		public extern ListViewBaseAutomationPeer([In] ListViewBase owner);
	}
}
