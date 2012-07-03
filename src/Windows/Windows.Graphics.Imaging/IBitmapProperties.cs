using System;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
namespace Windows.Graphics.Imaging
{
	[ExclusiveTo(typeof(BitmapProperties)), Guid(3936309019u, 46341, 17488, 164, 209, 232, 202, 148, 82, 157, 141), Version(100794368u)]
	internal interface IBitmapProperties : IBitmapPropertiesView
	{
		IAsyncAction SetPropertiesAsync([In] IIterable<IKeyValuePair<string, BitmapTypedValue>> propertiesToSet);
	}
}
