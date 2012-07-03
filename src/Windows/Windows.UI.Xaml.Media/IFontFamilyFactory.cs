using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(FontFamily)), Guid(3579851639u, 15790, 19917, 175, 9, 249, 73, 142, 158, 198, 89), Version(100794368u), WebHostHidden]
	internal interface IFontFamilyFactory
	{
		FontFamily CreateInstanceWithName([In] string familyName, [In] object outer, out object inner);
	}
}
