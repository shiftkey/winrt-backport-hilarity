using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(CompositeTransform)), Guid(3366205531u, 62026, 18177, 162, 101, 167, 136, 70, 241, 66, 185), Version(100794368u), WebHostHidden]
	internal interface ICompositeTransform
	{
		double CenterX
		{
			get;
			set;
		}
		double CenterY
		{
			get;
			set;
		}
		double Rotation
		{
			get;
			set;
		}
		double ScaleX
		{
			get;
			set;
		}
		double ScaleY
		{
			get;
			set;
		}
		double SkewX
		{
			get;
			set;
		}
		double SkewY
		{
			get;
			set;
		}
		double TranslateX
		{
			get;
			set;
		}
		double TranslateY
		{
			get;
			set;
		}
	}
}
