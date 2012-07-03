using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(ColorAnimation)), Guid(3098446357u, 3939, 18068, 148, 103, 189, 175, 172, 18, 83, 234), Version(100794368u), WebHostHidden]
	internal interface IColorAnimation
	{
		IReference<Color> By
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
		IReference<Color> From
		{
			get;
			set;
		}
		IReference<Color> To
		{
			get;
			set;
		}
	}
}
