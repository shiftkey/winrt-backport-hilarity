using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IExponentialEaseStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class ExponentialEase : EasingFunctionBase, IExponentialEase
	{
		public extern double Exponent
		{
			get;
			set;
		}
		public static extern DependencyProperty ExponentProperty
		{
			get;
		}
		public extern ExponentialEase();
	}
}
