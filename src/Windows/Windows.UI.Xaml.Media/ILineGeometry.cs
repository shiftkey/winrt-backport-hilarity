using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Media
{
	[ExclusiveTo(typeof(LineGeometry)), Guid(820892834u, 36805, 16559, 167, 162, 194, 127, 231, 170, 19, 99), Version(100794368u), WebHostHidden]
	internal interface ILineGeometry
	{
		Point EndPoint
		{
			get;
			set;
		}
		Point StartPoint
		{
			get;
			set;
		}
	}
}
