using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IGridPatternIdentifiersStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class GridPatternIdentifiers : IGridPatternIdentifiers
	{
		public static extern AutomationProperty ColumnCountProperty
		{
			get;
		}
		public static extern AutomationProperty RowCountProperty
		{
			get;
		}
	}
}
