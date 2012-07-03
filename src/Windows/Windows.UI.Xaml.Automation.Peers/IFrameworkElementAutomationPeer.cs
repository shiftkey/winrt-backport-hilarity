using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation.Peers
{
	[ExclusiveTo(typeof(FrameworkElementAutomationPeer)), Guid(3104495489u, 49131, 17489, 189, 71, 159, 58, 99, 235, 210, 74), Version(100794368u), WebHostHidden]
	internal interface IFrameworkElementAutomationPeer
	{
		UIElement Owner
		{
			get;
		}
	}
}
