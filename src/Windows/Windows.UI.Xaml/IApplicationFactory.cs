using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[ExclusiveTo(typeof(Application)), Guid(2478564193u, 48730, 20195, 180, 163, 149, 17, 141, 201, 122, 137), Version(100794368u), WebHostHidden]
	internal interface IApplicationFactory
	{
		Application CreateInstance([In] object outer, out object inner);
	}
}
