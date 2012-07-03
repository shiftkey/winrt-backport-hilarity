using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(SplitOpenThemeAnimation)), Guid(2019547050u, 21590, 17977, 143, 210, 38, 186, 230, 165, 255, 228), Version(100794368u), WebHostHidden]
	internal interface ISplitOpenThemeAnimation
	{
		double ClosedLength
		{
			get;
			set;
		}
		DependencyObject ClosedTarget
		{
			get;
			set;
		}
		string ClosedTargetName
		{
			get;
			set;
		}
		DependencyObject ContentTarget
		{
			get;
			set;
		}
		string ContentTargetName
		{
			get;
			set;
		}
		AnimationDirection ContentTranslationDirection
		{
			get;
			set;
		}
		double ContentTranslationOffset
		{
			get;
			set;
		}
		double OffsetFromCenter
		{
			get;
			set;
		}
		double OpenedLength
		{
			get;
			set;
		}
		DependencyObject OpenedTarget
		{
			get;
			set;
		}
		string OpenedTargetName
		{
			get;
			set;
		}
	}
}
