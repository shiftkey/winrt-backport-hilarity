using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Web.Syndication
{
	[ExclusiveTo(typeof(SyndicationError)), Guid(532357985u, 17863, 18483, 138, 160, 190, 95, 59, 88, 167, 244), Version(100794368u)]
	internal interface ISyndicationErrorStatics
	{
		SyndicationErrorStatus GetStatus([In] int hresult);
	}
}
