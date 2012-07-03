using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(TranslateTransform)), Guid(3379925084u, 15414, 16937, 129, 123, 23, 143, 100, 192, 225, 19), Version(100794368u), WebHostHidden]
	internal interface ITranslateTransform
	{
		double X
		{
			get;
			set;
		}
		double Y
		{
			get;
			set;
		}
	}
}
