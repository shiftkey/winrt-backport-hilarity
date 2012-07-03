using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation
{
	[ExclusiveTo(typeof(RangeValuePatternIdentifiers)), Guid(3458417935u, 7207, 17791, 184, 21, 122, 94, 70, 134, 61, 187), Version(100794368u), WebHostHidden]
	internal interface IRangeValuePatternIdentifiersStatics
	{
		AutomationProperty IsReadOnlyProperty
		{
			get;
		}
		AutomationProperty LargeChangeProperty
		{
			get;
		}
		AutomationProperty MaximumProperty
		{
			get;
		}
		AutomationProperty MinimumProperty
		{
			get;
		}
		AutomationProperty SmallChangeProperty
		{
			get;
		}
		AutomationProperty ValueProperty
		{
			get;
		}
	}
}
