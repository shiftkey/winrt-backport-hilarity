using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(EasingPointKeyFrame)), Guid(3016299392u, 26728, 16933, 167, 11, 57, 129, 204, 11, 41, 71), Version(100794368u), WebHostHidden]
	internal interface IEasingPointKeyFrame
	{
		EasingFunctionBase EasingFunction
		{
			get;
			set;
		}
	}
}
