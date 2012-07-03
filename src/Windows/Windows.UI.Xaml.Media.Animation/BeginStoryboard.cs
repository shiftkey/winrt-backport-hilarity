using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;
namespace Windows.UI.Xaml.Media.Animation
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IBeginStoryboardStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden, ContentProperty(Name = "Storyboard")]
	public sealed class BeginStoryboard : TriggerAction, IBeginStoryboard
	{
		public extern Storyboard Storyboard
		{
			get;
			set;
		}
		public static extern DependencyProperty StoryboardProperty
		{
			get;
		}
		public extern BeginStoryboard();
	}
}
