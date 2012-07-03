using System;
using Windows.Foundation.Metadata;
namespace Windows.Globalization.Fonts
{
	[ExclusiveTo(typeof(LanguageFontGroup)), Guid(4080697283u, 14940, 19178, 185, 255, 179, 159, 178, 66, 247, 246), Version(100794368u)]
	internal interface ILanguageFontGroup
	{
		LanguageFont DocumentAlternate1Font
		{
			get;
		}
		LanguageFont DocumentAlternate2Font
		{
			get;
		}
		LanguageFont DocumentHeadingFont
		{
			get;
		}
		LanguageFont FixedWidthTextFont
		{
			get;
		}
		LanguageFont ModernDocumentFont
		{
			get;
		}
		LanguageFont TraditionalDocumentFont
		{
			get;
		}
		LanguageFont UICaptionFont
		{
			get;
		}
		LanguageFont UIHeadingFont
		{
			get;
		}
		LanguageFont UINotificationHeadingFont
		{
			get;
		}
		LanguageFont UITextFont
		{
			get;
		}
		LanguageFont UITitleFont
		{
			get;
		}
	}
}
