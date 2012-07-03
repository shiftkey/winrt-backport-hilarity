using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Interop
{
	[ExclusiveTo(typeof(NotifyCollectionChangedEventArgs)), Guid(3003924026u, 57229, 17573, 154, 56, 122, 192, 208, 140, 230, 61), Version(100794368u), WebHostHidden]
	internal interface INotifyCollectionChangedEventArgsFactory
	{
		NotifyCollectionChangedEventArgs CreateInstanceWithAllParameters([In] NotifyCollectionChangedAction action, [In] IBindableVector newItems, [In] IBindableVector oldItems, [In] int newIndex, [In] int oldIndex, [In] object outer, out object inner);
	}
}
