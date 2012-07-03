using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Provider;
using Windows.UI.Xaml.Controls;
namespace Windows.UI.Xaml.Automation.Peers
{
	[Composable(typeof(IScrollViewerAutomationPeerFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class ScrollViewerAutomationPeer : FrameworkElementAutomationPeer, IScrollViewerAutomationPeer, IScrollProvider
	{
		public extern double HorizontalScrollPercent
		{
			get;
		}
		public extern double HorizontalViewSize
		{
			get;
		}
		public extern bool HorizontallyScrollable
		{
			get;
		}
		public extern double VerticalScrollPercent
		{
			get;
		}
		public extern double VerticalViewSize
		{
			get;
		}
		public extern bool VerticallyScrollable
		{
			get;
		}
		public extern ScrollViewerAutomationPeer([In] ScrollViewer owner);
		public extern void Scroll([In] ScrollAmount horizontalAmount, [In] ScrollAmount verticalAmount);
		public extern void SetScrollPercent([In] double horizontalPercent, [In] double verticalPercent);
	}
}
