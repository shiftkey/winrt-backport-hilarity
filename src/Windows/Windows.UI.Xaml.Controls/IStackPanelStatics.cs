using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(StackPanel)), Guid(4040215955u, 19900, 18599, 153, 20, 149, 73, 36, 101, 119, 113), Version(100794368u), WebHostHidden]
	internal interface IStackPanelStatics
	{
		DependencyProperty AreScrollSnapPointsRegularProperty
		{
			get;
		}
		DependencyProperty OrientationProperty
		{
			get;
		}
	}
}
