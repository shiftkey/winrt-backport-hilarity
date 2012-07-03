using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation
{
	[ExclusiveTo(typeof(TablePatternIdentifiers)), Guid(1963408677u, 13001, 18691, 174, 207, 220, 53, 4, 203, 210, 68), Version(100794368u), WebHostHidden]
	internal interface ITablePatternIdentifiersStatics
	{
		AutomationProperty ColumnHeadersProperty
		{
			get;
		}
		AutomationProperty RowHeadersProperty
		{
			get;
		}
		AutomationProperty RowOrColumnMajorProperty
		{
			get;
		}
	}
}
