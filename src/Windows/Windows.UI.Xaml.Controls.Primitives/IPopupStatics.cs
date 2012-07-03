using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[ExclusiveTo(typeof(Popup)), Guid(1524875034u, 28212, 16598, 138, 127, 202, 130, 42, 175, 89, 227), Version(100794368u), WebHostHidden]
	internal interface IPopupStatics
	{
		DependencyProperty ChildProperty
		{
			get;
		}
		DependencyProperty ChildTransitionsProperty
		{
			get;
		}
		DependencyProperty HorizontalOffsetProperty
		{
			get;
		}
		DependencyProperty IsLightDismissEnabledProperty
		{
			get;
		}
		DependencyProperty IsOpenProperty
		{
			get;
		}
		DependencyProperty VerticalOffsetProperty
		{
			get;
		}
	}
}
