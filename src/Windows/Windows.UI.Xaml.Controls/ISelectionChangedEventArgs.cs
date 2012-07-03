using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(SelectionChangedEventArgs)), Guid(3379745500u, 46601, 18264, 133, 30, 167, 153, 194, 29, 233, 125), Version(100794368u), WebHostHidden]
	internal interface ISelectionChangedEventArgs
	{
		IVector<object> AddedItems
		{
			get;
		}
		IVector<object> RemovedItems
		{
			get;
		}
	}
}
