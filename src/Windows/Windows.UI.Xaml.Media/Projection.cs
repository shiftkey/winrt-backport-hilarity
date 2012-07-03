using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[Composable(typeof(IProjectionFactory), CompositionType.Protected, 100794368u), MarshalingBehavior(MarshalingType.Agile), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class Projection : DependencyObject, IProjection
	{
		protected extern Projection();
	}
}
