using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Globalization.Fonts
{
	[Activatable(typeof(ILanguageFontGroupFactory), 100794368u), DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.MTA), Version(100794368u)]
	public sealed class LanguageFontGroup : ILanguageFontGroup
	{
		public extern LanguageFont DocumentAlternate1Font
		{
			get;
		}
		public extern LanguageFont DocumentAlternate2Font
		{
			get;
		}
		public extern LanguageFont DocumentHeadingFont
		{
			get;
		}
		public extern LanguageFont FixedWidthTextFont
		{
			get;
		}
		public extern LanguageFont ModernDocumentFont
		{
			get;
		}
		public extern LanguageFont TraditionalDocumentFont
		{
			get;
		}
		public extern LanguageFont UICaptionFont
		{
			get;
		}
		public extern LanguageFont UIHeadingFont
		{
			get;
		}
		public extern LanguageFont UINotificationHeadingFont
		{
			get;
		}
		public extern LanguageFont UITextFont
		{
			get;
		}
		public extern LanguageFont UITitleFont
		{
			get;
		}
		public extern LanguageFontGroup([In] string languageTag);
	}
}
