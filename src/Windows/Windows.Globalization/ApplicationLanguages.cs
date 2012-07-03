using System;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Globalization
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IApplicationLanguagesStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public static class ApplicationLanguages
	{
		public static extern IVectorView<string> Languages
		{
			get;
		}
		public static extern IVectorView<string> ManifestLanguages
		{
			get;
		}
		public static extern string PrimaryLanguageOverride
		{
			get;
			set;
		}
	}
}
