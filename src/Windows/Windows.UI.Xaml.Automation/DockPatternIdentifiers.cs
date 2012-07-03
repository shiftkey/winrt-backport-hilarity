using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IDockPatternIdentifiersStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class DockPatternIdentifiers : IDockPatternIdentifiers
	{
		public static extern AutomationProperty DockPositionProperty
		{
			get;
		}
	}
}
