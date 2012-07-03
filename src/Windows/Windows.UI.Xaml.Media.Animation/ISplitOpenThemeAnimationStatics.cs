using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(SplitOpenThemeAnimation)), Guid(2370632329u, 14993, 17805, 176, 251, 76, 173, 98, 92, 191, 141), Version(100794368u), WebHostHidden]
	internal interface ISplitOpenThemeAnimationStatics
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
