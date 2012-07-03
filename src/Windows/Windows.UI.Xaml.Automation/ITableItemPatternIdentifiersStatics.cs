using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation
{
	[ExclusiveTo(typeof(TableItemPatternIdentifiers)), Guid(616872227u, 59810, 19945, 178, 164, 168, 178, 45, 11, 227, 98), Version(100794368u), WebHostHidden]
	internal interface ITableItemPatternIdentifiersStatics
	{
		AutomationProperty ColumnHeaderItemsProperty
		{
			get;
		}
		AutomationProperty RowHeaderItemsProperty
		{
			get;
		}
	}
}
