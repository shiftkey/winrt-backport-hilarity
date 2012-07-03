using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class SizeChangedEventArgs : RoutedEventArgs, ISizeChangedEventArgs
	{
		public extern Size NewSize
		{
			get;
		}
		public extern Size PreviousSize
		{
			get;
		}
	}
}
