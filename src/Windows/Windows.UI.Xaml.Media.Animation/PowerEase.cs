using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IPowerEaseStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class PowerEase : EasingFunctionBase, IPowerEase
	{
		public extern double Power
		{
			get;
			set;
		}
		public static extern DependencyProperty PowerProperty
		{
			get;
		}
		public extern PowerEase();
	}
}
