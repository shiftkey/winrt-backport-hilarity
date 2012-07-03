using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Data
{
	[ExclusiveTo(typeof(BindingOperations)), Guid(3780505459u, 38304, 19115, 140, 125, 42, 71, 218, 7, 60, 121), Version(100794368u), WebHostHidden]
	internal interface IBindingOperationsStatics
	{
		void SetBinding([In] DependencyObject target, [In] DependencyProperty dp, [In] BindingBase binding);
	}
}
