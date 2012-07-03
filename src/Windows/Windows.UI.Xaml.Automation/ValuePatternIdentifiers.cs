using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IValuePatternIdentifiersStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class ValuePatternIdentifiers : IValuePatternIdentifiers
	{
		public static extern AutomationProperty IsReadOnlyProperty
		{
			get;
		}
		public static extern AutomationProperty ValueProperty
		{
			get;
		}
	}
}
