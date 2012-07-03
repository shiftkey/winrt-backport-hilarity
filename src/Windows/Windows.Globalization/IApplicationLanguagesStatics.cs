using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Globalization
{
	[ExclusiveTo(typeof(ApplicationLanguages)), Guid(1974732871u, 2636, 19090, 149, 101, 253, 99, 201, 95, 122, 237), Version(100794368u)]
	internal interface IApplicationLanguagesStatics
	{
		IVectorView<string> Languages
		{
			get;
		}
		IVectorView<string> ManifestLanguages
		{
			get;
		}
		string PrimaryLanguageOverride
		{
			get;
			set;
		}
	}
}
