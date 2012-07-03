using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;
namespace Windows.UI.Xaml.Shapes
{
	[Composable(typeof(IPathFactory), CompositionType.Public, 100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IPathStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public class Path : Shape, IPath
	{
		public extern Geometry Data
		{
			get;
			set;
		}
		public static extern DependencyProperty DataProperty
		{
			get;
		}
		public extern Path();
	}
}
