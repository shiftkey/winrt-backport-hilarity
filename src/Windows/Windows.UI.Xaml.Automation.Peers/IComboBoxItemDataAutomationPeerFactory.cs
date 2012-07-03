using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation.Peers
{
	[ExclusiveTo(typeof(ComboBoxItemDataAutomationPeer)), Guid(346608886u, 18074, 16826, 157, 147, 68, 161, 165, 93, 168, 114), Version(100794368u), WebHostHidden]
	internal interface IComboBoxItemDataAutomationPeerFactory
	{
		ComboBoxItemDataAutomationPeer CreateInstanceWithParentAndItem([In] object item, [In] ComboBoxAutomationPeer parent, [In] object outer, out object inner);
	}
}
