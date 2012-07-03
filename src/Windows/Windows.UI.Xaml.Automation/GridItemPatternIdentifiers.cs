using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IGridItemPatternIdentifiersStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class GridItemPatternIdentifiers : IGridItemPatternIdentifiers
	{
		public static extern AutomationProperty ColumnProperty
		{
			get;
		}
		public static extern AutomationProperty ColumnSpanProperty
		{
			get;
		}
		public static extern AutomationProperty ContainingGridProperty
		{
			get;
		}
		public static extern AutomationProperty RowProperty
		{
			get;
		}
		public static extern AutomationProperty RowSpanProperty
		{
			get;
		}
	}
}
