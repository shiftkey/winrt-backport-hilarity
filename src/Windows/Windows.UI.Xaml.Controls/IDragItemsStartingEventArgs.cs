using System;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(DragItemsStartingEventArgs)), Guid(1909399900u, 56045, 18307, 170, 17, 220, 87, 77, 39, 19, 233), Version(100794368u), WebHostHidden]
	internal interface IDragItemsStartingEventArgs
	{
		bool Cancel
		{
			get;
			set;
		}
		DataPackage Data
		{
			get;
		}
		IVector<object> Items
		{
			get;
		}
	}
}
