using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
	[ExclusiveTo(typeof(Uri))]
	internal interface IUriRuntimeClassFactory
	{
		[Overload("CreateUri")]
		Uri CreateUri([In] string uri);
		[Overload("CreateWithRelativeUri")]
		Uri CreateUri([In] string baseUri, [In] string relativeUri);
	}
}
