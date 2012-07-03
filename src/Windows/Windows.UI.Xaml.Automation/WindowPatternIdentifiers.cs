using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IWindowPatternIdentifiersStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class WindowPatternIdentifiers : IWindowPatternIdentifiers
	{
		public static extern AutomationProperty CanMaximizeProperty
		{
			get;
		}
		public static extern AutomationProperty CanMinimizeProperty
		{
			get;
		}
		public static extern AutomationProperty IsModalProperty
		{
			get;
		}
		public static extern AutomationProperty IsTopmostProperty
		{
			get;
		}
		public static extern AutomationProperty WindowInteractionStateProperty
		{
			get;
		}
		public static extern AutomationProperty WindowVisualStateProperty
		{
			get;
		}
	}
}
