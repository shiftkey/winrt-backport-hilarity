using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IBounceEaseStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class BounceEase : EasingFunctionBase, IBounceEase
	{
		public extern int Bounces
		{
			get;
			set;
		}
		public extern double Bounciness
		{
			get;
			set;
		}
		public static extern DependencyProperty BouncesProperty
		{
			get;
		}
		public static extern DependencyProperty BouncinessProperty
		{
			get;
		}
		public extern BounceEase();
	}
}
