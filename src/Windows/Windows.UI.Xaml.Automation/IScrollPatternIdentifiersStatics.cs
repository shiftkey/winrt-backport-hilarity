using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation
{
	[ExclusiveTo(typeof(ScrollPatternIdentifiers)), Guid(1274601633u, 64383, 20388, 131, 179, 207, 174, 177, 3, 166, 133), Version(100794368u), WebHostHidden]
	internal interface IScrollPatternIdentifiersStatics
	{
		AutomationProperty HorizontalScrollPercentProperty
		{
			get;
		}
		AutomationProperty HorizontalViewSizeProperty
		{
			get;
		}
		AutomationProperty HorizontallyScrollableProperty
		{
			get;
		}
		double NoScroll
		{
			get;
		}
		AutomationProperty VerticalScrollPercentProperty
		{
			get;
		}
		AutomationProperty VerticalViewSizeProperty
		{
			get;
		}
		AutomationProperty VerticallyScrollableProperty
		{
			get;
		}
	}
}
