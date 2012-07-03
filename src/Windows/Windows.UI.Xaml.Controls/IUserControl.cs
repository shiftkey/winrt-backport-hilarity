using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(UserControl)), Guid(2812714697u, 59957, 18041, 191, 41, 244, 240, 146, 134, 211, 20), Version(100794368u), WebHostHidden]
	internal interface IUserControl
	{
		UIElement Content
		{
			get;
			set;
		}
	}
}
