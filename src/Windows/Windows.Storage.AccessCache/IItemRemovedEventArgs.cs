using System;
using Windows.Foundation.Metadata;
namespace Windows.Storage.AccessCache
{
	[ExclusiveTo(typeof(ItemRemovedEventArgs)), Guid(1499954780u, 21950, 19558, 186, 102, 94, 174, 167, 157, 38, 49), Version(100794368u)]
	internal interface IItemRemovedEventArgs
	{
		AccessListEntry RemovedEntry
		{
			get;
		}
	}
}
