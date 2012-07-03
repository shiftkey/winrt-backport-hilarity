using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;
namespace Windows.UI.Xaml.Media
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IPathGeometryStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden, ContentProperty(Name = "Figures")]
	public sealed class PathGeometry : Geometry, IPathGeometry
	{
		public extern PathFigureCollection Figures
		{
			get;
			set;
		}
		public extern FillRule FillRule
		{
			get;
			set;
		}
		public static extern DependencyProperty FiguresProperty
		{
			get;
		}
		public static extern DependencyProperty FillRuleProperty
		{
			get;
		}
		public extern PathGeometry();
	}
}
