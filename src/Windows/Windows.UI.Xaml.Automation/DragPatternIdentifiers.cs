using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IDragPatternIdentifiersStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class DragPatternIdentifiers : IDragPatternIdentifiers
	{
		public static extern AutomationProperty DropEffectProperty
		{
			get;
		}
		public static extern AutomationProperty DropEffectsProperty
		{
			get;
		}
		public static extern AutomationProperty GrabbedItemsProperty
		{
			get;
		}
		public static extern AutomationProperty IsGrabbedProperty
		{
			get;
		}
	}
}
