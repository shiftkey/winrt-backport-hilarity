using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[Composable(typeof(IDragDeltaEventArgsFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class DragDeltaEventArgs : RoutedEventArgs, IDragDeltaEventArgs
	{
		public extern double HorizontalChange
		{
			get;
		}
		public extern double VerticalChange
		{
			get;
		}
		public extern DragDeltaEventArgs([In] double horizontalChange, [In] double verticalChange);
	}
}
