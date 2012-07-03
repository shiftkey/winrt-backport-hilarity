using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IBackEaseStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class BackEase : EasingFunctionBase, IBackEase
	{
		public extern double Amplitude
		{
			get;
			set;
		}
		public static extern DependencyProperty AmplitudeProperty
		{
			get;
		}
		public extern BackEase();
	}
}
