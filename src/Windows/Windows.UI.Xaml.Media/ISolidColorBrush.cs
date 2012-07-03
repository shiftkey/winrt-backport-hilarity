using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(SolidColorBrush)), Guid(2642741328u, 26355, 18655, 154, 143, 130, 75, 213, 224, 112, 175), Version(100794368u), WebHostHidden]
	internal interface ISolidColorBrush
	{
		Color Color
		{
			get;
			set;
		}
	}
}
