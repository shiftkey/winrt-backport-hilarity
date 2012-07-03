using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
namespace Windows.UI.Xaml.Media.Animation
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(ISplitCloseThemeAnimationStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class SplitCloseThemeAnimation : Timeline, ISplitCloseThemeAnimation
	{
		public extern double ClosedLength
		{
			get;
			set;
		}
		public extern DependencyObject ClosedTarget
		{
			get;
			set;
		}
		public extern string ClosedTargetName
		{
			get;
			set;
		}
		public extern DependencyObject ContentTarget
		{
			get;
			set;
		}
		public extern string ContentTargetName
		{
			get;
			set;
		}
		public extern AnimationDirection ContentTranslationDirection
		{
			get;
			set;
		}
		public extern double ContentTranslationOffset
		{
			get;
			set;
		}
		public extern double OffsetFromCenter
		{
			get;
			set;
		}
		public extern double OpenedLength
		{
			get;
			set;
		}
		public extern DependencyObject OpenedTarget
		{
			get;
			set;
		}
		public extern string OpenedTargetName
		{
			get;
			set;
		}
		public static extern DependencyProperty ClosedLengthProperty
		{
			get;
		}
		public static extern DependencyProperty ClosedTargetNameProperty
		{
			get;
		}
		public static extern DependencyProperty ClosedTargetProperty
		{
			get;
		}
		public static extern DependencyProperty ContentTargetNameProperty
		{
			get;
		}
		public static extern DependencyProperty ContentTargetProperty
		{
			get;
		}
		public static extern DependencyProperty ContentTranslationDirectionProperty
		{
			get;
		}
		public static extern DependencyProperty ContentTranslationOffsetProperty
		{
			get;
		}
		public static extern DependencyProperty OffsetFromCenterProperty
		{
			get;
		}
		public static extern DependencyProperty OpenedLengthProperty
		{
			get;
		}
		public static extern DependencyProperty OpenedTargetNameProperty
		{
			get;
		}
		public static extern DependencyProperty OpenedTargetProperty
		{
			get;
		}
		public extern SplitCloseThemeAnimation();
	}
}
