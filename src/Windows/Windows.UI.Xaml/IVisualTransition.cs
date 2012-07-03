using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(VisualTransition)), Guid(1439010910u, 11207, 16397, 170, 164, 26, 41, 129, 73, 30, 224), Version(100794368u), WebHostHidden]
	internal interface IVisualTransition
	{
		string From
		{
			get;
			set;
		}
		Duration GeneratedDuration
		{
			get;
			set;
		}
		EasingFunctionBase GeneratedEasingFunction
		{
			get;
			set;
		}
		Storyboard Storyboard
		{
			get;
			set;
		}
		string To
		{
			get;
			set;
		}
	}
}
