using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(ITogglePatternIdentifiersStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class TogglePatternIdentifiers : ITogglePatternIdentifiers
	{
		public static extern AutomationProperty ToggleStateProperty
		{
			get;
		}
	}
}
