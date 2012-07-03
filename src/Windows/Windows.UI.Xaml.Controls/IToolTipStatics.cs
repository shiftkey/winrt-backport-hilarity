using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(ToolTip)), Guid(4026697144u, 19369, 20303, 134, 167, 134, 0, 56, 19, 206, 179), Version(100794368u), WebHostHidden]
	internal interface IToolTipStatics
	{
		DependencyProperty HorizontalOffsetProperty
		{
			get;
		}
		DependencyProperty IsOpenProperty
		{
			get;
		}
		DependencyProperty PlacementProperty
		{
			get;
		}
		DependencyProperty PlacementTargetProperty
		{
			get;
		}
		DependencyProperty VerticalOffsetProperty
		{
			get;
		}
	}
}
