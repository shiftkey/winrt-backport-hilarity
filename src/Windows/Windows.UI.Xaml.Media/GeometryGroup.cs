using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;
namespace Windows.UI.Xaml.Media
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IGeometryGroupStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden, ContentProperty(Name = "Children")]
	public sealed class GeometryGroup : Geometry, IGeometryGroup
	{
		public extern GeometryCollection Children
		{
			get;
			set;
		}
		public extern FillRule FillRule
		{
			get;
			set;
		}
		public static extern DependencyProperty ChildrenProperty
		{
			get;
		}
		public static extern DependencyProperty FillRuleProperty
		{
			get;
		}
		public extern GeometryGroup();
	}
}
