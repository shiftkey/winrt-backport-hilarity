using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(StackPanel)), Guid(1675109514u, 35636, 17498, 128, 143, 182, 236, 214, 42, 39, 217), Version(100794368u), WebHostHidden]
	internal interface IStackPanelFactory
	{
		StackPanel CreateInstance([In] object outer, out object inner);
	}
}
