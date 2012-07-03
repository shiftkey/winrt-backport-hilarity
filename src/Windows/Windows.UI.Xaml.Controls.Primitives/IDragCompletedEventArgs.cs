using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[ExclusiveTo(typeof(DragCompletedEventArgs)), Guid(2957978017u, 48406, 18678, 165, 17, 156, 39, 99, 100, 19, 49), Version(100794368u), WebHostHidden]
	internal interface IDragCompletedEventArgs
	{
		bool Canceled
		{
			get;
		}
		double HorizontalChange
		{
			get;
		}
		double VerticalChange
		{
			get;
		}
	}
}
