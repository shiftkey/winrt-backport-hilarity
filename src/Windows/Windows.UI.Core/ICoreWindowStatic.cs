using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Core
{
	[ExclusiveTo(typeof(CoreWindow)), Guid(1294176261u, 15402, 16817, 144, 34, 83, 107, 185, 207, 147, 177), Version(100794368u), WebHostHidden]
	internal interface ICoreWindowStatic
	{
		CoreWindow GetForCurrentThread();
	}
}
