using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[Composable(typeof(ISelectionChangedEventArgsFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class SelectionChangedEventArgs : RoutedEventArgs, ISelectionChangedEventArgs
	{
		public extern IVector<object> AddedItems
		{
			get;
		}
		public extern IVector<object> RemovedItems
		{
			get;
		}
		public extern SelectionChangedEventArgs([In] IVector<object> removedItems, [In] IVector<object> addedItems);
	}
}
