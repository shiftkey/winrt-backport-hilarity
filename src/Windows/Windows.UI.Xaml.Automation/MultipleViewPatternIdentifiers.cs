using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IMultipleViewPatternIdentifiersStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class MultipleViewPatternIdentifiers : IMultipleViewPatternIdentifiers
	{
		public static extern AutomationProperty CurrentViewProperty
		{
			get;
		}
		public static extern AutomationProperty SupportedViewsProperty
		{
			get;
		}
	}
}
