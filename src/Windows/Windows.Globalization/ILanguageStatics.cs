using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Globalization
{
	[ExclusiveTo(typeof(Language)), Guid(2990331223u, 2149, 18132, 137, 184, 213, 155, 232, 153, 15, 13), Version(100794368u)]
	internal interface ILanguageStatics
	{
		string CurrentInputMethodLanguageTag
		{
			get;
		}
		bool IsWellFormed([In] string languageTag);
	}
}
