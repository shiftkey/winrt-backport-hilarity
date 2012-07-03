using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[Composable(typeof(IDragCompletedEventArgsFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class DragCompletedEventArgs : RoutedEventArgs, IDragCompletedEventArgs
	{
		public extern bool Canceled
		{
			get;
		}
		public extern double HorizontalChange
		{
			get;
		}
		public extern double VerticalChange
		{
			get;
		}
		public extern DragCompletedEventArgs([In] double horizontalChange, [In] double verticalChange, [In] bool canceled);
	}
}
