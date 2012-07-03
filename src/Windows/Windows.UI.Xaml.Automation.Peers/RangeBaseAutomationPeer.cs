using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Automation.Provider;
using Windows.UI.Xaml.Controls.Primitives;
namespace Windows.UI.Xaml.Automation.Peers
{
	[Composable(typeof(IRangeBaseAutomationPeerFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class RangeBaseAutomationPeer : FrameworkElementAutomationPeer, IRangeBaseAutomationPeer, IRangeValueProvider
	{
		public extern bool IsReadOnly
		{
			get;
		}
		public extern double LargeChange
		{
			get;
		}
		public extern double Maximum
		{
			get;
		}
		public extern double Minimum
		{
			get;
		}
		public extern double SmallChange
		{
			get;
		}
		public extern double Value
		{
			get;
		}
		public extern RangeBaseAutomationPeer([In] RangeBase owner);
		public extern void SetValue([In] double value);
	}
}
