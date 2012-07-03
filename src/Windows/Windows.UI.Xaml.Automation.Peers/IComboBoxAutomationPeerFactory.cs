using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;
namespace Windows.UI.Xaml.Automation.Peers
{
	[ExclusiveTo(typeof(ComboBoxAutomationPeer)), Guid(160324365u, 7056, 16569, 155, 227, 178, 50, 103, 235, 19, 207), Version(100794368u), WebHostHidden]
	internal interface IComboBoxAutomationPeerFactory
	{
		ComboBoxAutomationPeer CreateInstanceWithOwner([In] ComboBox owner, [In] object outer, out object inner);
	}
}
