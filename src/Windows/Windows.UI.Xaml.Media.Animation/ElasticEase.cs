using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IElasticEaseStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class ElasticEase : EasingFunctionBase, IElasticEase
	{
		public extern int Oscillations
		{
			get;
			set;
		}
		public extern double Springiness
		{
			get;
			set;
		}
		public static extern DependencyProperty OscillationsProperty
		{
			get;
		}
		public static extern DependencyProperty SpringinessProperty
		{
			get;
		}
		public extern ElasticEase();
	}
}
