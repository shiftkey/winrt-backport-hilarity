using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;
namespace Windows.UI.Xaml
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden, ContentProperty(Name = "Actions")]
	public sealed class EventTrigger : TriggerBase, IEventTrigger
	{
		public extern TriggerActionCollection Actions
		{
			get;
		}
		public extern RoutedEvent RoutedEvent
		{
			get;
			set;
		}
		public extern EventTrigger();
	}
}
