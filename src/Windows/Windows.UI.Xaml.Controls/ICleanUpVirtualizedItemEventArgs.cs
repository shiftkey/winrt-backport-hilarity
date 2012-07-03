using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(CleanUpVirtualizedItemEventArgs)), Guid(3926248681u, 37756, 16672, 132, 6, 121, 33, 133, 120, 67, 56), Version(100794368u), WebHostHidden]
	internal interface ICleanUpVirtualizedItemEventArgs
	{
		bool Cancel
		{
			get;
			set;
		}
		UIElement UIElement
		{
			get;
		}
		object Value
		{
			get;
		}
	}
}
