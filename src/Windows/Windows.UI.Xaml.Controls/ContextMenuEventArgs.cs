using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class ContextMenuEventArgs : RoutedEventArgs, IContextMenuEventArgs
	{
		public extern double CursorLeft
		{
			get;
		}
		public extern double CursorTop
		{
			get;
		}
		public extern bool Handled
		{
			get;
			set;
		}
	}
}
