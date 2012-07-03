using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.ApplicationModel.Resources.Core
{
	[ExclusiveTo(typeof(ResourceManager)), Guid(482409980u, 27118, 20035, 153, 1, 71, 241, 38, 135, 186, 247), Version(100794368u)]
	internal interface IResourceManagerStatics
	{
		ResourceManager Current
		{
			get;
		}
		bool IsResourceReference([In] string resourceReference);
	}
}
