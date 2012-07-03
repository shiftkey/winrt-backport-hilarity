using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;
namespace Windows.UI.Xaml.Media
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(ITranslateTransformStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class TranslateTransform : Transform, ITranslateTransform
	{
		public extern double X
		{
			get;
			set;
		}
		public extern double Y
		{
			get;
			set;
		}
		public static extern DependencyProperty XProperty
		{
			[IndependentlyAnimatable]
			get;
		}
		public static extern DependencyProperty YProperty
		{
			[IndependentlyAnimatable]
			get;
		}
		public extern TranslateTransform();
	}
}
