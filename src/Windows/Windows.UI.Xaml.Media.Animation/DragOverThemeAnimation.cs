using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
namespace Windows.UI.Xaml.Media.Animation
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IDragOverThemeAnimationStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class DragOverThemeAnimation : Timeline, IDragOverThemeAnimation
	{
		public extern AnimationDirection Direction
		{
			get;
			set;
		}
		public extern string TargetName
		{
			get;
			set;
		}
		public extern double ToOffset
		{
			get;
			set;
		}
		public static extern DependencyProperty DirectionProperty
		{
			get;
		}
		public static extern DependencyProperty TargetNameProperty
		{
			get;
		}
		public static extern DependencyProperty ToOffsetProperty
		{
			get;
		}
		public extern DragOverThemeAnimation();
	}
}
