using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[Activatable(100794368u), MarshalingBehavior(MarshalingType.Agile), Static(typeof(IMatrixTransformStatics), 100794368u), Threading(ThreadingModel.Both), Version(100794368u), WebHostHidden]
	public sealed class MatrixTransform : Transform, IMatrixTransform
	{
		public extern Matrix Matrix
		{
			get;
			set;
		}
		public static extern DependencyProperty MatrixProperty
		{
			get;
		}
		public extern MatrixTransform();
	}
}
