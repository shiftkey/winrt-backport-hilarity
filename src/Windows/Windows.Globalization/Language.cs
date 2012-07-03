using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Globalization
{
	[Activatable(typeof(ILanguageFactory), 100794368u), DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(ILanguageStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public sealed class Language : ILanguage
	{
		public extern string DisplayName
		{
			get;
		}
		public extern string LanguageTag
		{
			get;
		}
		public extern string NativeName
		{
			get;
		}
		public extern string Script
		{
			get;
		}
		public static extern string CurrentInputMethodLanguageTag
		{
			get;
		}
		public extern Language([In] string languageTag);
		public static extern bool IsWellFormed([In] string languageTag);
	}
}
