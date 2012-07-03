using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;
namespace Windows.UI.Xaml.Automation.Peers
{
	[ExclusiveTo(typeof(PasswordBoxAutomationPeer)), Guid(2889711326u, 56484, 18460, 181, 32, 74, 155, 63, 59, 23, 156), Version(100794368u), WebHostHidden]
	internal interface IPasswordBoxAutomationPeerFactory
	{
		PasswordBoxAutomationPeer CreateInstanceWithOwner([In] PasswordBox owner, [In] object outer, out object inner);
	}
}
