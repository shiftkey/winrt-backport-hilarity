using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation
{
	[ExclusiveTo(typeof(GridItemPatternIdentifiers)), Guid(561849346u, 24134, 19809, 135, 148, 184, 238, 142, 119, 71, 20), Version(100794368u), WebHostHidden]
	internal interface IGridItemPatternIdentifiersStatics
	{
		AutomationProperty ColumnProperty
		{
			get;
		}
		AutomationProperty ColumnSpanProperty
		{
			get;
		}
		AutomationProperty ContainingGridProperty
		{
			get;
		}
		AutomationProperty RowProperty
		{
			get;
		}
		AutomationProperty RowSpanProperty
		{
			get;
		}
	}
}
