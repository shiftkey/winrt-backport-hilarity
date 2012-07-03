using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation
{
	[ExclusiveTo(typeof(SelectionPatternIdentifiers)), Guid(2466470732u, 27472, 16545, 178, 63, 92, 120, 221, 189, 71, 154), Version(100794368u), WebHostHidden]
	internal interface ISelectionPatternIdentifiersStatics
	{
		AutomationProperty CanSelectMultipleProperty
		{
			get;
		}
		AutomationProperty IsSelectionRequiredProperty
		{
			get;
		}
		AutomationProperty SelectionProperty
		{
			get;
		}
	}
}
