using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Data.Html
{
	[ExclusiveTo(typeof(HtmlUtilities)), Guid(4273998557u, 9113, 20396, 181, 167, 5, 233, 172, 215, 24, 29), Version(100794368u), WebHostHidden]
	internal interface IHtmlUtilities
	{
		string ConvertToText([In] string html);
	}
}
