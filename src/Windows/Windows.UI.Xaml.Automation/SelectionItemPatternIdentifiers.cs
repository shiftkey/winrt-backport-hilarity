using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(ISelectionItemPatternIdentifiersStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class SelectionItemPatternIdentifiers : ISelectionItemPatternIdentifiers
	{
		public static extern AutomationProperty IsSelectedProperty
		{
			get;
		}
		public static extern AutomationProperty SelectionContainerProperty
		{
			get;
		}
	}
}
