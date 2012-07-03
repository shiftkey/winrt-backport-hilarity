using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Data
{
	[Guid(2347286500u, 56303, 17631, 129, 38, 163, 26, 137, 18, 29, 220), Version(100794368u), WebHostHidden]
	public interface ICollectionView : IObservableVector<object>, IVector<object>, IIterable<object>
	{
		event EventHandler<object> CurrentChanged;
		event CurrentChangingEventHandler CurrentChanging;
		IObservableVector<object> CollectionGroups
		{
			get;
		}
		object CurrentItem
		{
			get;
		}
		int CurrentPosition
		{
			get;
		}
		bool HasMoreItems
		{
			get;
		}
		bool IsCurrentAfterLast
		{
			get;
		}
		bool IsCurrentBeforeFirst
		{
			get;
		}
		bool MoveCurrentTo([In] object item);
		bool MoveCurrentToPosition([In] int index);
		bool MoveCurrentToFirst();
		bool MoveCurrentToLast();
		bool MoveCurrentToNext();
		bool MoveCurrentToPrevious();
		IAsyncOperation<LoadMoreItemsResult> LoadMoreItemsAsync([In] uint count);
	}
}
