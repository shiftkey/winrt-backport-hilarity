using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.DataTransfer
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IHtmlFormatHelperStatics), 100794368u), Version(100794368u)]
	public static class HtmlFormatHelper
	{
		public static extern string GetStaticFragment([In] string htmlFormat);
		public static extern string CreateHtmlFormat([In] string htmlFragment);
	}
}
