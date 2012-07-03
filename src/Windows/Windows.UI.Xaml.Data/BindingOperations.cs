using System;
using System.Runtime.InteropServices;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Data
{
	[MarshalingBehavior(MarshalingType.Agile), Static(typeof(IBindingOperationsStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class BindingOperations : IBindingOperations
	{
		public static extern void SetBinding([In] DependencyObject target, [In] DependencyProperty dp, [In] BindingBase binding);
	}
}
