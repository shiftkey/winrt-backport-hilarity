using System;
using Windows.Foundation.Metadata;
namespace Windows.Foundation
{
	[ExclusiveTo(typeof(Uri))]
	internal interface IUriRuntimeClassWithAbsoluteCanonicalUri
	{
		string AbsoluteCanonicalUri { get; }
		string DisplayIri { get; }
	}
}
