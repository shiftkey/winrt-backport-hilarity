using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(MatrixTransform)), Guid(1138765383u, 5560, 18264, 187, 151, 125, 82, 66, 10, 204, 91), Version(100794368u), WebHostHidden]
	internal interface IMatrixTransformStatics
	{
		DependencyProperty MatrixProperty
		{
			get;
		}
	}
}
