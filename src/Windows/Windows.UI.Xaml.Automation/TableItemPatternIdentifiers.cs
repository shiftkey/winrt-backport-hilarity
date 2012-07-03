using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(ITableItemPatternIdentifiersStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class TableItemPatternIdentifiers : ITableItemPatternIdentifiers
	{
		public static extern AutomationProperty ColumnHeaderItemsProperty
		{
			get;
		}
		public static extern AutomationProperty RowHeaderItemsProperty
		{
			get;
		}
	}
}
