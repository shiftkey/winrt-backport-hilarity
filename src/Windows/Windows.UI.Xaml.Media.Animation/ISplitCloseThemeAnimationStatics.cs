using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(SplitCloseThemeAnimation)), Guid(2057915881u, 52379, 20112, 161, 26, 0, 80, 162, 33, 106, 158), Version(100794368u), WebHostHidden]
	internal interface ISplitCloseThemeAnimationStatics
	{
		DependencyProperty ClosedLengthProperty
		{
			get;
		}
		DependencyProperty ClosedTargetNameProperty
		{
			get;
		}
		DependencyProperty ClosedTargetProperty
		{
			get;
		}
		DependencyProperty ContentTargetNameProperty
		{
			get;
		}
		DependencyProperty ContentTargetProperty
		{
			get;
		}
		DependencyProperty ContentTranslationDirectionProperty
		{
			get;
		}
		DependencyProperty ContentTranslationOffsetProperty
		{
			get;
		}
		DependencyProperty OffsetFromCenterProperty
		{
			get;
		}
		DependencyProperty OpenedLengthProperty
		{
			get;
		}
		DependencyProperty OpenedTargetNameProperty
		{
			get;
		}
		DependencyProperty OpenedTargetProperty
		{
			get;
		}
	}
}
