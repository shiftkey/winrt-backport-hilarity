using System;
using Windows.Foundation.Metadata;
namespace Windows.UI.Xaml.Shapes
{
	[ExclusiveTo(typeof(Line)), Guid(1185235773u, 20475, 18655, 135, 50, 78, 21, 200, 52, 129, 107), Version(100794368u), WebHostHidden]
	internal interface ILine
	{
		double X1
		{
			get;
			set;
		}
		double X2
		{
			get;
			set;
		}
		double Y1
		{
			get;
			set;
		}
		double Y2
		{
			get;
			set;
		}
	}
}
