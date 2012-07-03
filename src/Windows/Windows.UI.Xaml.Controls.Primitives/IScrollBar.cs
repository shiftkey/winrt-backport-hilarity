using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[ExclusiveTo(typeof(ScrollBar)), Guid(4118472394u, 53670, 19344, 164, 233, 84, 223, 27, 168, 210, 236), Version(100794368u), WebHostHidden]
	internal interface IScrollBar
	{
		event ScrollEventHandler Scroll;
		ScrollingIndicatorMode IndicatorMode
		{
			get;
			set;
		}
		Orientation Orientation
		{
			get;
			set;
		}
		double ViewportSize
		{
			get;
			set;
		}
	}
}
