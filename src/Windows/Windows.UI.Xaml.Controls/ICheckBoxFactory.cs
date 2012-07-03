using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Controls
{
	[ExclusiveTo(typeof(CheckBox)), Guid(1336322747u, 16203, 17153, 190, 7, 17, 114, 234, 97, 238, 251), Version(100794368u), WebHostHidden]
	internal interface ICheckBoxFactory
	{
		CheckBox CreateInstance([In] object outer, out object inner);
	}
}
