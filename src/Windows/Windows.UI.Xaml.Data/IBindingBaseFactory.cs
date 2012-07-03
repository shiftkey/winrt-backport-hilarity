using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Data
{
	[ExclusiveTo(typeof(BindingBase)), Guid(584776762u, 30465, 18022, 161, 186, 152, 89, 189, 207, 236, 52), Version(100794368u), WebHostHidden]
	internal interface IBindingBaseFactory
	{
		BindingBase CreateInstance([In] object outer, out object inner);
	}
}
