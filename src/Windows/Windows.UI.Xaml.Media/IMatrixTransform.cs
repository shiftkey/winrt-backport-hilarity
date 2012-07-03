using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(MatrixTransform)), Guid(3992835409u, 24557, 17916, 174, 98, 146, 164, 182, 207, 151, 7), Version(100794368u), WebHostHidden]
	internal interface IMatrixTransform
	{
		Matrix Matrix
		{
			get;
			set;
		}
	}
}
