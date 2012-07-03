using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation
{
	[ExclusiveTo(typeof(DragPatternIdentifiers)), Guid(704984989u, 5973, 16514, 157, 144, 70, 241, 65, 29, 121, 134), Version(100794368u), WebHostHidden]
	internal interface IDragPatternIdentifiersStatics
	{
		AutomationProperty DropEffectProperty
		{
			get;
		}
		AutomationProperty DropEffectsProperty
		{
			get;
		}
		AutomationProperty GrabbedItemsProperty
		{
			get;
		}
		AutomationProperty IsGrabbedProperty
		{
			get;
		}
	}
}
