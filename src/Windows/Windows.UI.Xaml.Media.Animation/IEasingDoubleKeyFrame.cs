using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(EasingDoubleKeyFrame)), Guid(2522536845u, 39508, 16648, 180, 255, 181, 165, 33, 44, 179, 56), Version(100794368u), WebHostHidden]
	internal interface IEasingDoubleKeyFrame
	{
		EasingFunctionBase EasingFunction
		{
			get;
			set;
		}
	}
}
