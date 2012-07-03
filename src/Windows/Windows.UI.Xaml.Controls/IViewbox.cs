using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(Viewbox)), Guid(86322264u, 47773, 18441, 158, 195, 250, 13, 22, 113, 11, 161), Version(100794368u), WebHostHidden]
	internal interface IViewbox
	{
		UIElement Child
		{
			get;
			set;
		}
		Stretch Stretch
		{
			get;
			set;
		}
		StretchDirection StretchDirection
		{
			get;
			set;
		}
	}
}
