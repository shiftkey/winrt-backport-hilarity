using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.System.Threading.Core
{
	[ExclusiveTo(typeof(PreallocatedWorkItem)), Guid(3067783676u, 48219, 16410, 168, 178, 110, 117, 77, 20, 218, 166), Version(100794368u), WebHostHidden]
	internal interface IPreallocatedWorkItem
	{
		IAsyncAction RunAsync();
	}
}
