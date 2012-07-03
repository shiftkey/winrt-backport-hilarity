using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;
namespace Windows.UI.Xaml.Media.Animation
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IPaneThemeTransitionStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class PaneThemeTransition : Transition, IPaneThemeTransition
	{
		public extern EdgeTransitionLocation Edge
		{
			get;
			set;
		}
		public static extern DependencyProperty EdgeProperty
		{
			get;
		}
		public extern PaneThemeTransition();
	}
}
