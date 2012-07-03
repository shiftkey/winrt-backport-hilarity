using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media.Animation
{
	[ExclusiveTo(typeof(EasingFunctionBase)), Guid(3238541375u, 11266, 16721, 142, 205, 104, 221, 170, 63, 13, 155), Version(100794368u), WebHostHidden]
	internal interface IEasingFunctionBase
	{
		EasingMode EasingMode
		{
			get;
			set;
		}
		double Ease([In] double normalizedTime);
	}
}
