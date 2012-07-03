using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation.Peers
{
	[ExclusiveTo(typeof(AutomationPeer)), Guid(549614917u, 43147, 17352, 188, 36, 206, 169, 218, 253, 4, 163), Version(100794368u), WebHostHidden]
	internal interface IAutomationPeerFactory
	{
		AutomationPeer CreateInstance([In] object outer, out object inner);
	}
}
