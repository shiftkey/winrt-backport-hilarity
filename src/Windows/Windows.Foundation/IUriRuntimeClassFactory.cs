using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.Foundation
{
	[ExclusiveTo(typeof(Uri)), Guid(1151957359u, 29246, 20447, 162, 24, 3, 62, 117, 176, 192, 132), Version(100794368u)]
	internal interface IUriRuntimeClassFactory
	{
		[Overload("CreateUri")]
		Uri CreateUri([In] string uri);
		[Overload("CreateWithRelativeUri")]
		Uri CreateUri([In] string baseUri, [In] string relativeUri);
	}
}
