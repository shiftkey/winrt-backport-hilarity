using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(AppBar)), Guid(2042330765u, 56489, 19295, 164, 72, 55, 177, 50, 56, 237, 118), Version(100794368u), WebHostHidden]
	internal interface IAppBarStatics
	{
		DependencyProperty IsOpenProperty
		{
			get;
		}
		DependencyProperty IsStickyProperty
		{
			get;
		}
	}
}
