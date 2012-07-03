using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Input
{
	[ExclusiveTo(typeof(InertiaRotationBehavior)), Guid(1112341294u, 48125, 17957, 174, 120, 32, 198, 91, 241, 239, 175), Version(100794368u), WebHostHidden]
	internal interface IInertiaRotationBehavior
	{
		double DesiredDeceleration
		{
			get;
			set;
		}
		double DesiredRotation
		{
			get;
			set;
		}
	}
}
