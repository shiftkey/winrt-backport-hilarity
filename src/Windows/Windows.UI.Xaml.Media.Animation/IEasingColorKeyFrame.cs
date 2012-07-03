using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(EasingColorKeyFrame)), Guid(3342063152u, 62649, 18740, 155, 221, 39, 172, 94, 209, 207, 216), Version(100794368u), WebHostHidden]
	internal interface IEasingColorKeyFrame
	{
		EasingFunctionBase EasingFunction
		{
			get;
			set;
		}
	}
}
