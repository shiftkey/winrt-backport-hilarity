using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(SplitCloseThemeAnimation)), Guid(1333368088u, 65337, 20112, 187, 116, 42, 189, 86, 2, 116, 2), Version(100794368u), WebHostHidden]
	internal interface ISplitCloseThemeAnimation
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
