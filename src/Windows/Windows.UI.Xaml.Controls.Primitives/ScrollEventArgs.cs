using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class ScrollEventArgs : RoutedEventArgs, IScrollEventArgs
	{
		public extern double NewValue
		{
			get;
		}
		public extern ScrollEventType ScrollEventType
		{
			get;
		}
		public extern ScrollEventArgs();
	}
}
