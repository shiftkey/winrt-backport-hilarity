using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Printing
{
	[Version(100794368u)]
	public struct PrintPageDescription
	{
		public Size PageSize;
		public Rect ImageableRect;
		public uint DpiX;
		public uint DpiY;
	}
}
