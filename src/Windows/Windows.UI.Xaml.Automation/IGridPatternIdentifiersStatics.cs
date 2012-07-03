using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation
{
	[ExclusiveTo(typeof(GridPatternIdentifiers)), Guid(2076463859u, 41345, 16695, 141, 233, 31, 155, 26, 131, 32, 237), Version(100794368u), WebHostHidden]
	internal interface IGridPatternIdentifiersStatics
	{
		AutomationProperty ColumnCountProperty
		{
			get;
		}
		AutomationProperty RowCountProperty
		{
			get;
		}
	}
}
