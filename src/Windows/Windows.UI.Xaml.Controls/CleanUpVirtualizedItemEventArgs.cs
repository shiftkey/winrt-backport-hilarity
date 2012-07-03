using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class CleanUpVirtualizedItemEventArgs : RoutedEventArgs, ICleanUpVirtualizedItemEventArgs
	{
		public extern bool Cancel
		{
			get;
			set;
		}
		public extern UIElement UIElement
		{
			get;
		}
		public extern object Value
		{
			get;
		}
	}
}
