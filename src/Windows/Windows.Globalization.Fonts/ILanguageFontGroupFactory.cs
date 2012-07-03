using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Globalization.Fonts
{
	[ExclusiveTo(typeof(LanguageFontGroup)), Guid(4239305831u, 20087, 18887, 184, 86, 221, 233, 52, 252, 115, 91), Version(100794368u)]
	internal interface ILanguageFontGroupFactory
	{
		LanguageFontGroup CreateLanguageFontGroup([In] string languageTag);
	}
}
