using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Input
{
	[ExclusiveTo(typeof(ManipulationStartedRoutedEventArgs)), Guid(2227296935u, 29298, 17507, 182, 195, 164, 11, 155, 161, 81, 252), Version(100794368u), WebHostHidden]
	internal interface IManipulationStartedRoutedEventArgsFactory
	{
		ManipulationStartedRoutedEventArgs CreateInstance([In] object outer, out object inner);
	}
}
