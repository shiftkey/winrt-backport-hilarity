using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation.Peers
{
	[ExclusiveTo(typeof(ItemAutomationPeer)), Guid(2503750902u, 15153, 18343, 179, 191, 37, 211, 174, 153, 195, 23), Version(100794368u), WebHostHidden]
	internal interface IItemAutomationPeer
	{
		object Item
		{
			get;
		}
		ItemsControlAutomationPeer ItemsControlAutomationPeer
		{
			get;
		}
	}
}
