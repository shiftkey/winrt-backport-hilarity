using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Web
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IWebErrorStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public static class WebError
	{
		public static extern WebErrorStatus GetStatus([In] int hresult);
	}
}
