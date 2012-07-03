using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(ScrollViewerViewChangedEventArgs)), Guid(1305497470u, 31249, 19246, 153, 51, 87, 125, 243, 146, 82, 182), Version(100794368u), WebHostHidden]
	internal interface IScrollViewerViewChangedEventArgs
	{
		bool IsIntermediate
		{
			get;
		}
	}
}
