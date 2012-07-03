using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(FontFamily)), Guid(2454093412u, 54890, 19700, 147, 34, 61, 35, 179, 192, 195, 97), Version(100794368u), WebHostHidden]
	internal interface IFontFamily
	{
		string Source
		{
			get;
		}
	}
}
