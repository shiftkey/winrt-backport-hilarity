using System;
using Windows.Foundation.Metadata;
using Windows.UI.Text;
namespace Windows.Globalization.Fonts
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class LanguageFont : ILanguageFont
	{
		public extern string FontFamily
		{
			get;
		}
		public extern FontStretch FontStretch
		{
			get;
		}
		public extern FontStyle FontStyle
		{
			get;
		}
		public extern FontWeight FontWeight
		{
			get;
		}
		public extern double ScaleFactor
		{
			get;
		}
	}
}
