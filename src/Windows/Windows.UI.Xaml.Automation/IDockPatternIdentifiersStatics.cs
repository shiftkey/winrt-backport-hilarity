using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation
{
	[ExclusiveTo(typeof(DockPatternIdentifiers)), Guid(730276956u, 60800, 20453, 142, 180, 112, 138, 57, 200, 65, 229), Version(100794368u), WebHostHidden]
	internal interface IDockPatternIdentifiersStatics
	{
		AutomationProperty DockPositionProperty
		{
			get;
		}
	}
}
