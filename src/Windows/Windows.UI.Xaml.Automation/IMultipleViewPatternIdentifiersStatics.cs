using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation
{
	[ExclusiveTo(typeof(MultipleViewPatternIdentifiers)), Guid(2848958063u, 27524, 19825, 158, 72, 215, 100, 211, 188, 218, 142), Version(100794368u), WebHostHidden]
	internal interface IMultipleViewPatternIdentifiersStatics
	{
		AutomationProperty CurrentViewProperty
		{
			get;
		}
		AutomationProperty SupportedViewsProperty
		{
			get;
		}
	}
}
