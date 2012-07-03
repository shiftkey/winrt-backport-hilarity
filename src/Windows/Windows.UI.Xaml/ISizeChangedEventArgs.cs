using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(SizeChangedEventArgs)), Guid(3576770144u, 23745, 17057, 146, 12, 26, 244, 107, 226, 249, 134), Version(100794368u), WebHostHidden]
	internal interface ISizeChangedEventArgs
	{
		Size NewSize
		{
			get;
		}
		Size PreviousSize
		{
			get;
		}
	}
}
