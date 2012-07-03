using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(ITablePatternIdentifiersStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class TablePatternIdentifiers : ITablePatternIdentifiers
	{
		public static extern AutomationProperty ColumnHeadersProperty
		{
			get;
		}
		public static extern AutomationProperty RowHeadersProperty
		{
			get;
		}
		public static extern AutomationProperty RowOrColumnMajorProperty
		{
			get;
		}
	}
}
