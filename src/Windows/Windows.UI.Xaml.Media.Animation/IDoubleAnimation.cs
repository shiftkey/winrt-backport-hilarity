using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(DoubleAnimation)), Guid(2124365145u, 3847, 19401, 151, 125, 3, 118, 63, 248, 21, 79), Version(100794368u), WebHostHidden]
	internal interface IDoubleAnimation
	{
		IReference<double> By
		{
			get;
			set;
		}
		EasingFunctionBase EasingFunction
		{
			get;
			set;
		}
		bool EnableDependentAnimation
		{
			get;
			set;
		}
		IReference<double> From
		{
			get;
			set;
		}
		IReference<double> To
		{
			get;
			set;
		}
	}
}
