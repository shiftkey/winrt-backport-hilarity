using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(ISelectionPatternIdentifiersStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class SelectionPatternIdentifiers : ISelectionPatternIdentifiers
	{
		public static extern AutomationProperty CanSelectMultipleProperty
		{
			get;
		}
		public static extern AutomationProperty IsSelectionRequiredProperty
		{
			get;
		}
		public static extern AutomationProperty SelectionProperty
		{
			get;
		}
	}
}
