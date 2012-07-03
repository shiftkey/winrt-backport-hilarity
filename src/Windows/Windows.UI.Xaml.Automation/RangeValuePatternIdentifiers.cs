using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IRangeValuePatternIdentifiersStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class RangeValuePatternIdentifiers : IRangeValuePatternIdentifiers
	{
		public static extern AutomationProperty IsReadOnlyProperty
		{
			get;
		}
		public static extern AutomationProperty LargeChangeProperty
		{
			get;
		}
		public static extern AutomationProperty MaximumProperty
		{
			get;
		}
		public static extern AutomationProperty MinimumProperty
		{
			get;
		}
		public static extern AutomationProperty SmallChangeProperty
		{
			get;
		}
		public static extern AutomationProperty ValueProperty
		{
			get;
		}
	}
}
