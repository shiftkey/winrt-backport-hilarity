using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;
namespace Windows.UI.Xaml.Automation.Peers
{
	[ExclusiveTo(typeof(RadioButtonAutomationPeer)), Guid(1228981501u, 15752, 18890, 143, 49, 146, 65, 135, 175, 11, 254), Version(100794368u), WebHostHidden]
	internal interface IRadioButtonAutomationPeerFactory
	{
		RadioButtonAutomationPeer CreateInstanceWithOwner([In] RadioButton owner, [In] object outer, out object inner);
	}
}
