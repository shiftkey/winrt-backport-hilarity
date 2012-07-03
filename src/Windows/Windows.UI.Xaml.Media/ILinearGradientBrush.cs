using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(LinearGradientBrush)), Guid(2392248683u, 48004, 19567, 157, 191, 157, 108, 92, 109, 156, 57), Version(100794368u), WebHostHidden]
	internal interface ILinearGradientBrush
	{
		Point EndPoint
		{
			get;
			set;
		}
		Point StartPoint
		{
			get;
			set;
		}
	}
}
