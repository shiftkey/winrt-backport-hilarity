using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[Composable(typeof(IEasingFunctionBaseFactory), CompositionType.Protected, 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IEasingFunctionBaseStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class EasingFunctionBase : DependencyObject, IEasingFunctionBase
	{
		public extern EasingMode EasingMode
		{
			get;
			set;
		}
		public static extern DependencyProperty EasingModeProperty
		{
			get;
		}
		public extern double Ease([In] double normalizedTime);
	}
}
