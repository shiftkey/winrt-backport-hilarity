using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(MediaFailedRoutedEventArgs)), Guid(1188166285u, 20809, 16723, 186, 60, 176, 62, 100, 238, 83, 30), Version(100794368u), WebHostHidden]
	internal interface IMediaFailedRoutedEventArgs
	{
		string ErrorTrace
		{
			get;
		}
	}
}
