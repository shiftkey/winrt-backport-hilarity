using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;
namespace Windows.UI.Xaml.Controls.Primitives
{
	[ExclusiveTo(typeof(TickBar)), Guid(2571535354u, 61942, 18557, 165, 172, 193, 89, 33, 191, 169, 149), Version(100794368u), WebHostHidden]
	internal interface ITickBar
	{
		Brush Fill
		{
			get;
			set;
		}
	}
}
