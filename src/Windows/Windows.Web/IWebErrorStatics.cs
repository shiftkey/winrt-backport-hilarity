using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Web
{
	[ExclusiveTo(typeof(WebError)), Guid(4267796326u, 48935, 16484, 135, 183, 101, 99, 187, 17, 206, 46), Version(100794368u)]
	internal interface IWebErrorStatics
	{
		WebErrorStatus GetStatus([In] int hresult);
	}
}
