using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation
{
	[ExclusiveTo(typeof(SelectionItemPatternIdentifiers)), Guid(2836975971u, 18558, 20030, 159, 134, 123, 68, 172, 190, 39, 206), Version(100794368u), WebHostHidden]
	internal interface ISelectionItemPatternIdentifiersStatics
	{
		AutomationProperty IsSelectedProperty
		{
			get;
		}
		AutomationProperty SelectionContainerProperty
		{
			get;
		}
	}
}
