using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class ScrollViewerViewChangedEventArgs : IScrollViewerViewChangedEventArgs
	{
		public extern bool IsIntermediate
		{
			get;
		}
		public extern ScrollViewerViewChangedEventArgs();
	}
}
