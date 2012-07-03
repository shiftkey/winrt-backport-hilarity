using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IExpandCollapsePatternIdentifiersStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class ExpandCollapsePatternIdentifiers : IExpandCollapsePatternIdentifiers
	{
		public static extern AutomationProperty ExpandCollapseStateProperty
		{
			get;
		}
	}
}
