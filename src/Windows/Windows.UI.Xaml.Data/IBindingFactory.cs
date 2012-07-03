using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Data
{
	[ExclusiveTo(typeof(Binding)), Guid(4282563336u, 50078, 20350, 132, 52, 161, 86, 144, 131, 136, 60), Version(100794368u), WebHostHidden]
	internal interface IBindingFactory
	{
		Binding CreateInstance([In] object outer, out object inner);
	}
}
