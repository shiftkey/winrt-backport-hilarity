using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(ExceptionRoutedEventArgs)), Guid(3718246762u, 19298, 19052, 164, 157, 6, 113, 239, 97, 54, 190), Version(100794368u), WebHostHidden]
	internal interface IExceptionRoutedEventArgs
	{
		string ErrorMessage
		{
			get;
		}
	}
}
