using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;
namespace Windows.UI.Xaml.Automation.Peers
{
	[ExclusiveTo(typeof(ComboBoxItemAutomationPeer)), Guid(323667964u, 14714, 16447, 166, 236, 28, 232, 190, 218, 21, 229), Version(100794368u), WebHostHidden]
	internal interface IComboBoxItemAutomationPeerFactory
	{
		ComboBoxItemAutomationPeer CreateInstanceWithOwner([In] ComboBoxItem owner, [In] object outer, out object inner);
	}
}
