using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[Composable(typeof(IExceptionRoutedEventArgsFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class ExceptionRoutedEventArgs : RoutedEventArgs, IExceptionRoutedEventArgs
	{
		public extern string ErrorMessage
		{
			get;
		}
	}
}
