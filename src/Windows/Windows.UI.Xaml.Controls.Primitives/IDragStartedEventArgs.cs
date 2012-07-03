using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[ExclusiveTo(typeof(DragStartedEventArgs)), Guid(2677104080u, 41252, 17254, 189, 133, 36, 8, 33, 74, 238, 212), Version(100794368u), WebHostHidden]
	internal interface IDragStartedEventArgs
	{
		double HorizontalOffset
		{
			get;
		}
		double VerticalOffset
		{
			get;
		}
	}
}
