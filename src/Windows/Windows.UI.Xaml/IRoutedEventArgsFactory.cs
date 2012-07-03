using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(RoutedEventArgs)), Guid(3055308167u, 28901, 16686, 181, 32, 26, 65, 238, 118, 187, 244), Version(100794368u), WebHostHidden]
	internal interface IRoutedEventArgsFactory
	{
		RoutedEventArgs CreateInstance([In] object outer, out object inner);
	}
}
