using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
using Windows.Storage;
namespace Windows.Management.Core
{
	[ExclusiveTo(typeof(ApplicationDataManager)), Guid(504914659u, 27022, 18849, 151, 82, 222, 233, 73, 37, 185, 179), Version(100794368u)]
	internal interface IApplicationDataManagerStatics
	{
		ApplicationData CreateForPackageFamily([In] string packageFamilyName);
	}
}
