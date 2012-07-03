using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Input
{
	[ExclusiveTo(typeof(InertiaExpansionBehavior)), Guid(1964869605u, 36162, 17605, 150, 94, 60, 211, 12, 201, 214, 247), Version(100794368u), WebHostHidden]
	internal interface IInertiaExpansionBehavior
	{
		double DesiredDeceleration
		{
			get;
			set;
		}
		double DesiredExpansion
		{
			get;
			set;
		}
	}
}
