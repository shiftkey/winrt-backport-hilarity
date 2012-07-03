using System;
using Windows.Foundation.Metadata;
using Windows.UI.Text;
namespace Windows.Globalization.Fonts
{
	[ExclusiveTo(typeof(LanguageFont)), Guid(2972605498u, 46957, 17819, 190, 235, 144, 17, 81, 205, 119, 209), Version(100794368u)]
	internal interface ILanguageFont
	{
		string FontFamily
		{
			get;
		}
		FontStretch FontStretch
		{
			get;
		}
		FontStyle FontStyle
		{
			get;
		}
		FontWeight FontWeight
		{
			get;
		}
		double ScaleFactor
		{
			get;
		}
	}
}
