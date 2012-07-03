using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(SelectionChangedEventArgs)), Guid(296269493u, 10288, 17687, 132, 205, 85, 36, 200, 184, 139, 69), Version(100794368u), WebHostHidden]
	internal interface ISelectionChangedEventArgsFactory
	{
		SelectionChangedEventArgs CreateInstanceWithRemovedItemsAndAddedItems([In] IVector<object> removedItems, [In] IVector<object> addedItems, [In] object outer, out object inner);
	}
}
