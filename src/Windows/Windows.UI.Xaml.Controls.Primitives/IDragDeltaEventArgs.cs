using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[ExclusiveTo(typeof(DragDeltaEventArgs)), Guid(741201724u, 10246, 18940, 170, 233, 109, 121, 43, 87, 43, 106), Version(100794368u), WebHostHidden]
	internal interface IDragDeltaEventArgs
	{
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
