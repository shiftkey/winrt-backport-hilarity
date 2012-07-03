using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(ContentControl)), Guid(2869000985u, 6510, 20181, 162, 127, 85, 197, 143, 177, 103, 63), Version(100794368u), WebHostHidden]
	internal interface IContentControlFactory
	{
		ContentControl CreateInstance([In] object outer, out object inner);
	}
}
