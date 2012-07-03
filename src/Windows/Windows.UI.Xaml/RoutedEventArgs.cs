using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[Composable(typeof(IRoutedEventArgsFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class RoutedEventArgs : IRoutedEventArgs
	{
		public extern object OriginalSource
		{
			get;
		}
		public extern RoutedEventArgs();
	}
}
