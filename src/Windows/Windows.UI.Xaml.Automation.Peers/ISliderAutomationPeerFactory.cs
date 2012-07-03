using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;
namespace Windows.UI.Xaml.Automation.Peers
{
	[ExclusiveTo(typeof(SliderAutomationPeer)), Guid(2535161942u, 39546, 19961, 149, 250, 111, 92, 4, 201, 28, 172), Version(100794368u), WebHostHidden]
	internal interface ISliderAutomationPeerFactory
	{
		SliderAutomationPeer CreateInstanceWithOwner([In] Slider owner, [In] object outer, out object inner);
	}
}
