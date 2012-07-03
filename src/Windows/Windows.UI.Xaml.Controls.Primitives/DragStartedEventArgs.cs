using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[Composable(typeof(IDragStartedEventArgsFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class DragStartedEventArgs : RoutedEventArgs, IDragStartedEventArgs
	{
		public extern double HorizontalOffset
		{
			get;
		}
		public extern double VerticalOffset
		{
			get;
		}
		public extern DragStartedEventArgs([In] double horizontalOffset, [In] double verticalOffset);
	}
}
