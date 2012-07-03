using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Automation
{
	[ExclusiveTo(typeof(TransformPatternIdentifiers)), Guid(1165028779u, 55045, 16580, 161, 220, 233, 172, 252, 239, 133, 246), Version(100794368u), WebHostHidden]
	internal interface ITransformPatternIdentifiersStatics
	{
		AutomationProperty CanMoveProperty
		{
			get;
		}
		AutomationProperty CanResizeProperty
		{
			get;
		}
		AutomationProperty CanRotateProperty
		{
			get;
		}
	}
}
