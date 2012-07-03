using System;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class DragItemsStartingEventArgs : IDragItemsStartingEventArgs
	{
		public extern bool Cancel
		{
			get;
			set;
		}
		public extern DataPackage Data
		{
			get;
		}
		public extern IVector<object> Items
		{
			get;
		}
		public extern DragItemsStartingEventArgs();
	}
}
