using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Web.Syndication
{
	[DualApiPartition(version = 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(ISyndicationErrorStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u)]
	public static class SyndicationError
	{
		public static extern SyndicationErrorStatus GetStatus([In] int hresult);
	}
}
