using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;
namespace Windows.UI.Xaml.Automation.Peers
{
	[ExclusiveTo(typeof(TextBoxAutomationPeer)), Guid(32555111u, 38507, 16688, 184, 114, 70, 158, 66, 189, 74, 127), Version(100794368u), WebHostHidden]
	internal interface ITextBoxAutomationPeerFactory
	{
		TextBoxAutomationPeer CreateInstanceWithOwner([In] TextBox owner, [In] object outer, out object inner);
	}
}
