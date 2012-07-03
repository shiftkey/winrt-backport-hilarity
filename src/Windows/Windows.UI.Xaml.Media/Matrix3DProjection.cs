using System;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media.Media3D;
namespace Windows.UI.Xaml.Media
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IMatrix3DProjectionStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden, ContentProperty(Name = "ProjectionMatrix")]
	public sealed class Matrix3DProjection : Projection, IMatrix3DProjection
	{
		public extern Matrix3D ProjectionMatrix
		{
			get;
			set;
		}
		public static extern DependencyProperty ProjectionMatrixProperty
		{
			get;
		}
		public extern Matrix3DProjection();
	}
}
