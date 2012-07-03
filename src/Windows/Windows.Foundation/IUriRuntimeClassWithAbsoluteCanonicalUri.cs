using System;
using Windows.Foundation.Metadata;
namespace Windows.Foundation
{
	[ExclusiveTo(typeof(Uri)), Guid(1972213345u, 8732, 18447, 163, 57, 80, 101, 102, 115, 244, 111), Version(100794368u)]
	internal interface IUriRuntimeClassWithAbsoluteCanonicalUri
	{
		string AbsoluteCanonicalUri
		{
			get;
		}
		string DisplayIri
		{
			get;
		}
	}
}
