using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IScrollPatternIdentifiersStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class ScrollPatternIdentifiers : IScrollPatternIdentifiers
	{
		public static extern AutomationProperty HorizontalScrollPercentProperty
		{
			get;
		}
		public static extern AutomationProperty HorizontalViewSizeProperty
		{
			get;
		}
		public static extern AutomationProperty HorizontallyScrollableProperty
		{
			get;
		}
		public static extern double NoScroll
		{
			get;
		}
		public static extern AutomationProperty VerticalScrollPercentProperty
		{
			get;
		}
		public static extern AutomationProperty VerticalViewSizeProperty
		{
			get;
		}
		public static extern AutomationProperty VerticallyScrollableProperty
		{
			get;
		}
	}
}
