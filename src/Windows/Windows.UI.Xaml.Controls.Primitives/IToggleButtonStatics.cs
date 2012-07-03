using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[ExclusiveTo(typeof(ToggleButton)), Guid(2938022674u, 296, 20327, 156, 90, 130, 50, 12, 68, 93, 25), Version(100794368u), WebHostHidden]
	internal interface IToggleButtonStatics
	{
		DependencyProperty IsCheckedProperty
		{
			get;
		}
		DependencyProperty IsThreeStateProperty
		{
			get;
		}
	}
}
