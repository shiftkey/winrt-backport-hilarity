using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class MediaFailedRoutedEventArgs : ExceptionRoutedEventArgs, IMediaFailedRoutedEventArgs
	{
		public extern string ErrorTrace
		{
			get;
		}
	}
}
