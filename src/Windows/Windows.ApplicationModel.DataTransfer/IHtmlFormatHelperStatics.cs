using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.DataTransfer
{
	[ExclusiveTo(typeof(HtmlFormatHelper)), Guid(3794696009u, 56688, 17519, 174, 252, 97, 206, 229, 159, 101, 94), Version(100794368u)]
	internal interface IHtmlFormatHelperStatics
	{
		string GetStaticFragment([In] string htmlFormat);
		string CreateHtmlFormat([In] string htmlFragment);
	}
}
