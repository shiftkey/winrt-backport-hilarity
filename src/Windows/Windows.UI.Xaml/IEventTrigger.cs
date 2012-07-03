using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(EventTrigger)), Guid(3740858453u, 2889, 16519, 177, 169, 184, 179, 132, 136, 247, 134), Version(100794368u), WebHostHidden]
	internal interface IEventTrigger
	{
		TriggerActionCollection Actions
		{
			get;
		}
		RoutedEvent RoutedEvent
		{
			get;
			set;
		}
	}
}
