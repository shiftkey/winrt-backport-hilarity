using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Imaging
{
	[Guid(2114971770u, 14960, 18680, 156, 85, 25, 108, 245, 165, 69, 245), Version(100794368u)]
	public interface IBitmapPropertiesView
	{
		IAsyncOperation<BitmapPropertySet> GetPropertiesAsync([In] IIterable<string> propertiesToRetrieve);
	}
}
