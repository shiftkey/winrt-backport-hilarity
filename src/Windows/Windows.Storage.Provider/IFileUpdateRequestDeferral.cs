using System;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Provider
{
	[ExclusiveTo(typeof(FileUpdateRequestDeferral)), Guid(4291746603u, 35550, 17573, 187, 0, 22, 76, 78, 114, 241, 58), Version(100794368u)]
	internal interface IFileUpdateRequestDeferral
	{
		void Complete();
	}
}
