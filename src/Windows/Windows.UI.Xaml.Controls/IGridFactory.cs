using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(Grid)), Guid(2927706177u, 50481, 17332, 191, 153, 18, 245, 6, 247, 176, 28), Version(100794368u), WebHostHidden]
	internal interface IGridFactory
	{
		Grid CreateInstance([In] object outer, out object inner);
	}
}
