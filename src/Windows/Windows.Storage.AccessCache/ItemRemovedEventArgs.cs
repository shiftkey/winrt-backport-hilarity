using System;
using Windows.Foundation.Metadata;
namespace Windows.Storage.AccessCache
{
	[Version(100794368u)]
	public sealed class ItemRemovedEventArgs : IItemRemovedEventArgs
	{
		public extern AccessListEntry RemovedEntry
		{
			get;
		}
	}
}
