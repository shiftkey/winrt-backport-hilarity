using System;
using Windows.Foundation.Metadata;
namespace Windows.Globalization
{
	[ExclusiveTo(typeof(Language)), Guid(3933841234u, 63426, 16997, 177, 189, 196, 222, 196, 228, 240, 128), Version(100794368u)]
	internal interface ILanguage
	{
		string DisplayName
		{
			get;
		}
		string LanguageTag
		{
			get;
		}
		string NativeName
		{
			get;
		}
		string Script
		{
			get;
		}
	}
}
