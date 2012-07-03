using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Globalization
{
	[ExclusiveTo(typeof(Language)), Guid(2600620716u, 3111, 17656, 183, 146, 151, 147, 251, 102, 198, 62), Version(100794368u)]
	internal interface ILanguageFactory
	{
		Language CreateLanguage([In] string languageTag);
	}
}
