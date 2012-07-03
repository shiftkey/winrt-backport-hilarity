using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IDropTargetPatternIdentifiersStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class DropTargetPatternIdentifiers : IDropTargetPatternIdentifiers
	{
		public static extern AutomationProperty DropTargetEffectProperty
		{
			get;
		}
		public static extern AutomationProperty DropTargetEffectsProperty
		{
			get;
		}
	}
}
