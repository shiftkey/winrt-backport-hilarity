using System;
using Windows.Foundation.Metadata;
namespace Windows.Web.Syndication
{
	[Version(100794368u)]
	public enum SyndicationErrorStatus
	{
		Unknown,
		MissingRequiredElement,
		MissingRequiredAttribute,
		InvalidXml,
		UnexpectedContent,
		UnsupportedFormat
	}
}
