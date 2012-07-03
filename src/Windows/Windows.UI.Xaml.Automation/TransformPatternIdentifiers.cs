using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(ITransformPatternIdentifiersStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class TransformPatternIdentifiers : ITransformPatternIdentifiers
	{
		public static extern AutomationProperty CanMoveProperty
		{
			get;
		}
		public static extern AutomationProperty CanResizeProperty
		{
			get;
		}
		public static extern AutomationProperty CanRotateProperty
		{
			get;
		}
	}
}
