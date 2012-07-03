using System;
using System.Runtime.InteropServices;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class DragEventArgs : RoutedEventArgs, IDragEventArgs
	{
		public extern DataPackage Data
		{
			get;
			set;
		}
		public extern bool Handled
		{
			get;
			set;
		}
		public extern Point GetPosition([In] UIElement relativeTo);
	}
}
