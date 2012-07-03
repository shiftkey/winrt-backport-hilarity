using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(ColorAnimation)), Guid(1441461986u, 34787, 20296, 149, 143, 133, 91, 47, 158, 169, 236), Version(100794368u), WebHostHidden]
	internal interface IColorAnimationStatics
	{
		DependencyProperty ByProperty
		{
			get;
		}
		DependencyProperty EasingFunctionProperty
		{
			get;
		}
		DependencyProperty EnableDependentAnimationProperty
		{
			get;
		}
		DependencyProperty FromProperty
		{
			get;
		}
		DependencyProperty ToProperty
		{
			get;
		}
	}
}
