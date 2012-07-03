using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;
namespace Windows.UI.Xaml.Automation.Peers
{
	[ExclusiveTo(typeof(CheckBoxAutomationPeer)), Guid(3076290397u, 60303, 17647, 162, 124, 226, 106, 199, 222, 131, 51), Version(100794368u), WebHostHidden]
	internal interface ICheckBoxAutomationPeerFactory
	{
		CheckBoxAutomationPeer CreateInstanceWithOwner([In] CheckBox owner, [In] object outer, out object inner);
	}
}
