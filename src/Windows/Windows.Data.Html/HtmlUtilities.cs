using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Data.Html
{
	[MarshalingBehavior(MarshalingType.Standard), Static(typeof(IHtmlUtilities), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public static class HtmlUtilities
	{
		public static extern string ConvertToText([In] string html);
	}
}
