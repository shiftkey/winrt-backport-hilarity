using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Imaging
{
	[MarshalingBehavior(MarshalingType.Agile), Version(100794368u)]
	public sealed class BitmapPropertiesView : IBitmapPropertiesView
	{
		public extern IAsyncOperation<BitmapPropertySet> GetPropertiesAsync([In] IIterable<string> propertiesToRetrieve);
	}
}
