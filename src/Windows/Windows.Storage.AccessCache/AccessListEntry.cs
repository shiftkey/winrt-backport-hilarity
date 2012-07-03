using System;
using Windows.Foundation.Metadata;
namespace Windows.Storage.AccessCache
{
	[Version(100794368u)]
	public struct AccessListEntry
	{
		public string Token;
		public string Metadata;
	}
}
