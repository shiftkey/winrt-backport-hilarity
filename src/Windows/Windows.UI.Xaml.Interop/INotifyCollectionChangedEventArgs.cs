using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Interop
{
	[ExclusiveTo(typeof(NotifyCollectionChangedEventArgs)), Guid(1291226419u, 58354, 18788, 184, 94, 148, 91, 79, 126, 47, 33), Version(100794368u), WebHostHidden]
	internal interface INotifyCollectionChangedEventArgs
	{
		NotifyCollectionChangedAction Action
		{
			get;
		}
		IBindableVector NewItems
		{
			get;
		}
		int NewStartingIndex
		{
			get;
		}
		IBindableVector OldItems
		{
			get;
		}
		int OldStartingIndex
		{
			get;
		}
	}
}
