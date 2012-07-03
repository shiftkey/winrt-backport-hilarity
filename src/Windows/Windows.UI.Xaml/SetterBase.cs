using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml
{
	[Composable(typeof(ISetterBaseFactory), CompositionType.Protected, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class SetterBase : DependencyObject, ISetterBase
	{
		public extern bool IsSealed
		{
			get;
		}
	}
}
