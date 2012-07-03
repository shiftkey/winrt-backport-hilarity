using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IDropTargetItemThemeAnimationStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class DropTargetItemThemeAnimation : Timeline, IDropTargetItemThemeAnimation
	{
		public extern string TargetName
		{
			get;
			set;
		}
		public static extern DependencyProperty TargetNameProperty
		{
			get;
		}
		public extern DropTargetItemThemeAnimation();
	}
}
