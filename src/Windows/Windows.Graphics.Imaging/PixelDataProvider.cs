using System;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Imaging
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class PixelDataProvider : IPixelDataProvider
	{
		public extern byte[] DetachPixelData();
	}
}
