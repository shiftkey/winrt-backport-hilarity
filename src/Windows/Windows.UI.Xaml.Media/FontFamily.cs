using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[Composable(typeof(IFontFamilyFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class FontFamily : IFontFamily
	{
		public extern string Source
		{
			get;
		}
		public extern FontFamily([In] string familyName);
	}
}
