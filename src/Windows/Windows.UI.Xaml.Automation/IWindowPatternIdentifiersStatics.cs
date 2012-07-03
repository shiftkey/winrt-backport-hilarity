using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation
{
	[ExclusiveTo(typeof(WindowPatternIdentifiers)), Guid(131116294u, 25346, 19753, 135, 139, 25, 218, 3, 252, 34, 141), Version(100794368u), WebHostHidden]
	internal interface IWindowPatternIdentifiersStatics
	{
		AutomationProperty CanMaximizeProperty
		{
			get;
		}
		AutomationProperty CanMinimizeProperty
		{
			get;
		}
		AutomationProperty IsModalProperty
		{
			get;
		}
		AutomationProperty IsTopmostProperty
		{
			get;
		}
		AutomationProperty WindowInteractionStateProperty
		{
			get;
		}
		AutomationProperty WindowVisualStateProperty
		{
			get;
		}
	}
}
