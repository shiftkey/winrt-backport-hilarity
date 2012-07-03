using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Interop
{
	[Guid(682715093u, 6705, 18011, 155, 37, 213, 195, 174, 104, 108, 64), Version(100794368u), WebHostHidden]
	public interface INotifyCollectionChanged
	{
		event NotifyCollectionChangedEventHandler CollectionChanged;
	}
}
