using System;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Pickers.Provider
{
	[ExclusiveTo(typeof(FileRemovedEventArgs)), Guid(319045031u, 32714, 19499, 158, 202, 104, 144, 249, 240, 1, 133), Version(100794368u)]
	internal interface IFileRemovedEventArgs
	{
		string Id
		{
			get;
		}
	}
}
