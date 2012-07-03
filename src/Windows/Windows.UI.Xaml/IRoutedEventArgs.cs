using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(RoutedEventArgs)), Guid(1553488582u, 55298, 19256, 162, 35, 191, 7, 12, 67, 254, 223), Version(100794368u), WebHostHidden]
	internal interface IRoutedEventArgs
	{
		object OriginalSource
		{
			get;
		}
	}
}
