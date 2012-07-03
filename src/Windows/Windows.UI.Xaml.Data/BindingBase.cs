using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Data
{
	[Composable(typeof(IBindingBaseFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class BindingBase : DependencyObject, IBindingBase
	{
		public extern BindingBase();
	}
}
