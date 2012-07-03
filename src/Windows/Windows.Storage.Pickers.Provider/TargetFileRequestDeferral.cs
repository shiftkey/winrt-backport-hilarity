using System;
using Windows.Foundation.Metadata;
namespace Windows.Storage.Pickers.Provider
{
	[Version(100794368u)]
	public sealed class TargetFileRequestDeferral : ITargetFileRequestDeferral
	{
		public extern void Complete();
	}
}
